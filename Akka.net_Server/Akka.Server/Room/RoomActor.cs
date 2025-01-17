﻿using Akka.Actor;

using Google.Protobuf;
using Google.Protobuf.Protocol;

using Serilog;

using ServerCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akka.Server
{
    public class RoomActor : ReceiveActor
    {
        #region Message
        public class MsgGetClientCount { }
        public class MsgEnterClient
        {
            public ClientSession Session { get; }
            public MsgEnterClient(ClientSession session)
            {
                Session = session;
            }
        }
        public class MsgLeaveClient
        {
            public int ClientId { get; }
            public MsgLeaveClient(int clientId)
            {
                ClientId = clientId;
            }
        }
        #endregion

        #region Actor
        IActorRef _roomManger;
        IActorRef _sessionManager;
        #endregion

        public int RoomID { get; set; }
        Dictionary<int, ClientSession> _clients = new Dictionary<int, ClientSession>();

        public RoomActor(IActorRef roomMangerActor, IActorRef sessionManagerActor, int roomNumber)
        {
            _roomManger = roomMangerActor;
            _sessionManager = sessionManagerActor;

            RoomID = roomNumber;

            Receive<MsgEnterClient>(msg => EnterClientHandler(msg));
            Receive<MsgGetClientCount>(_ => Sender.Tell(_clients.Count));
            Receive<MsgLeaveClient>(msg => LeaveClientHandler(msg.ClientId));

            Receive<MessageCustom<ClientSession, C_Chat>>(msg => ChatHandle(msg.Item1, msg.Item2));
        }
        private void EnterClientHandler(MsgEnterClient client)
        {
            if (client.Session == null)
                return;

            ClientSession session = client.Session;
            if (_clients.ContainsKey(session.SessionID))
                return;

            _clients[session.SessionID] = session;
            session.Room = Self;

            {
                S_EnterServer enterPaket = new S_EnterServer() { Client = new ClientInfo() };
                enterPaket.Client.ObjectId = session.SessionID;

                client.Session.Send(enterPaket);
            }
            {
                S_Spawn spawnPacket = new S_Spawn();

                foreach (ClientSession p in _clients.Values)
                {
                    if (client.Session != p)
                        spawnPacket.ObjectIds.Add(p.SessionID);
                }
                client.Session.Send(spawnPacket);
            }
            // 타인한테 정보 전송
            {
                S_Spawn spawnPacket = new S_Spawn();
                spawnPacket.ObjectIds.Add(session.SessionID);
                foreach (ClientSession p in _clients.Values)
                {
                    if (client.Session != p)
                        client.Session.Send(spawnPacket);
                }
            }
            Log.Logger.Information($"[Room{RoomID}] Enter Client ID : {session.SessionID}");
        }
        private void LeaveClientHandler(int clientId)
        {
            ClientSession client = null;
            if (_clients.Remove(clientId, out client) == false)
                return;

            client.Room = null;
            _sessionManager.Tell(new SessionManagerActor.MsgRemoveSession(client));

            {
                S_LeaveServer leavePacket = new S_LeaveServer();
                client.Send(leavePacket);
            }

            //타인에게 전달
            {
                S_Despawn despawnPacket = new S_Despawn();
                despawnPacket.ObjectIds.Add(clientId);
                BroadcastExceptSelf(clientId, despawnPacket);
            }

            if (_clients.Count == 0)
                _roomManger.Tell(new RoomManagerActor.MsgRemoveRoom(RoomID));

            Log.Logger.Information($"[Room{RoomID}] Leave Client ID : {clientId}");
        }
        public void ChatHandle(ClientSession player, C_Chat chatPacket)
        {
            if (player == null)
                return;

            string chat = chatPacket.Chat;
            int id = player.SessionID;

            if (string.IsNullOrEmpty(chat))
                return;

            S_Chat severChatPacket = new S_Chat()
            {
                ObjectId = id,
                Chat = chatPacket.Chat + "\n"
            };

            ClusterActorManager.Instance.GetClusterActor(Define.ClusterType.LogManagerActor)?.Tell(severChatPacket);

            BroadCast(severChatPacket);
        }

        #region Util
        public void BroadCast(IMessage packet)
        {
            foreach (ClientSession client in _clients.Values)
            {
                client.Send(packet);
            }
        }
        public void BroadcastExceptSelf(int clientId, IMessage packet)
        {
            foreach (ClientSession p in _clients.Values)
            {
                if (p.SessionID != clientId)
                    p.Send(packet);
            }
        }
        #endregion;
    }
}
