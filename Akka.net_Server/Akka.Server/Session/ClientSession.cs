﻿using Akka.Actor;
using Google.Protobuf;
using Google.Protobuf.Protocol;

using Serilog;

using ServerCore;
using System.Net;

using static Akka.IO.UdpConnected;

namespace Akka.Server
{
    public partial class ClientSession : PacketSession
    {
        public IActorRef Room { get; set; }
        public IActorRef RoomManager;
        public IActorRef SessionManager;
        public int SessionID { get; set; }
        public string AccountName { get; set; }
        List<ArraySegment<byte>> _reservSendList = new List<ArraySegment<byte>>();
        object _lock = new object();

        long _lastSendTick = 0;
        int _reservedSendBytes = 0;
        public ClientSession(IActorRef sessionManager, IActorRef roomManager)
        {
            SessionManager = sessionManager;
            RoomManager = roomManager;
        }
        public void Send(IMessage packet)
        {
            string packetName = packet.Descriptor.Name.Replace("_", string.Empty);
            PacketID packetID = (PacketID)Enum.Parse(typeof(PacketID), packetName);

            ushort size = (ushort)packet.CalculateSize();
            byte[] sendBuffer = new byte[size + 4];

            Array.Copy(BitConverter.GetBytes((ushort)(size + 4)), 0, sendBuffer, 0, sizeof(ushort));
            Array.Copy(BitConverter.GetBytes((ushort)(packetID)), 0, sendBuffer, sizeof(ushort), sizeof(ushort));
            Array.Copy(packet.ToByteArray(), 0, sendBuffer, 4, size);

            //Console.WriteLine($"SEND - Packet : {packet.Descriptor.Name}, SessionId : {SessionID}");
            lock (_lock)
            {
                _reservSendList.Add(new ArraySegment<byte>(sendBuffer));
                _reservedSendBytes += sendBuffer.Length;
            }
        }
        public void FlushSend()
        {
            List<ArraySegment<byte>> sendList = null;

            lock (_lock)
            {
                long tick = Environment.TickCount64 - _lastSendTick;

                if (tick < 100 && _reservedSendBytes < 100000)
                    return;

                _reservedSendBytes = 0;
                _lastSendTick = Environment.TickCount64;

                sendList = _reservSendList;
                _reservSendList = new List<ArraySegment<byte>>();

            }
            Send(sendList);
        }
        public override void OnConnected(EndPoint endPoint)
        {
            Log.Logger.Information($"[ClientSession] OnConnected - IP : {endPoint}, SessionId : {SessionID}");
        }
        public override void OnDisconnected(EndPoint endPoint)
        {
            if (Room != null)
            {
                Room.Tell(new RoomActor.LeaveClientCommand(SessionID, true));
                Log.Logger.Information($"[ClientSession] Disconnected - IP : {endPoint}, SessionId : {SessionID}");
            }

            SessionManager.Tell(new SessionManagerActor.RemoveSessionCommand(this));
        }
        public override void OnRecvedPacket(ArraySegment<byte> buffer)
        {
            PacketManager.Instance.OnRecvPacket(this, buffer);
        }
        public override void OnSended(int numOfByte)
        {

        }
    }
}
