﻿using Akka.AccountServer.DB;
using Akka.AccountServer.Define;
using Akka.Actor;
using Akka.ClusterCore;
using Akka.Streams.Stage;

using Google.Protobuf.ClusterProtocol;

using Microsoft.EntityFrameworkCore;

namespace Akka.AccountServer.Actor
{
    public class AccountActor : ReceiveActor
    {
        #region Message
        public record AccountCommand<T>(AppDbContext Context, T Message);

        #endregion

        ActorSystem _actorSystem;
        public AccountActor(ActorSystem actorSystem)
        {
            _actorSystem = actorSystem;

            //회원가입
            Receive<AccountCommand<CreateAccountPacketReq>>((message) =>
            {
                AppDbContext context = message.Context;
                CreateAccountPacketReq req = message.Message;

                CreateAccountPacketRes res = new CreateAccountPacketRes();

                AccountDb account = context.Accounts
                                          .AsNoTracking()//read only로 성능 향상
                                          .Where(a => a.AccountName == req.AccountName)
                                          .FirstOrDefault();

                if (account == null)
                {
                    context.Accounts.Add(new AccountDb()
                    {
                        AccountName = req.AccountName,
                        Password = req.Password,
                    });

                    bool success = context.SaveChangesEx();
                    res.CreateOk = success;
                }
                else
                {
                    res.CreateOk = false;
                }

                Sender.Tell(res);
            });

            //로그인
            Receive<AccountCommand<LoginAccountPacketReq>>(async (message) =>
            {
                var task = HandleLogin(message);
                task.PipeTo(Sender, Self);
            });

            Receive<AccountCommand<GetRoomsAccountPacketReq>>(async (message) =>
            {
                var task = HandleRoomInfos(message);
                task.PipeTo(Sender, Self);
            });
        }
        private async Task<LoginAccountPacketRes> HandleLogin(AccountCommand<LoginAccountPacketReq> message)
        {
            var context = message.Context;
            var req = message.Message;

            var res = new LoginAccountPacketRes();
            var account = await context.Accounts
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(a => a.AccountName == req.AccountName && a.Password == req.Password);

            if (account == null)
            {
                res.LoginOk = false;
            }
            else
            {
                res.LoginOk = true;

                //Akka.Server에 모든 방 정보 받아오는 부분.
                {

                    var clusterLocator = new ClusterActorLocator(_actorSystem);

                    var response = await clusterLocator.AskClusterActor<SA_GetAllRoomInfoResponse>(
                        $"{TcpServerActorType.RoomManagerActor}",
                        new AS_GetAllRoomInfoQuery(),
                        TimeSpan.FromSeconds(50)
                    );

                    foreach (var info in response.RoomInfos)
                    {
                        res.RoomList.Add(new RoomInfo { RoomId = info.RoomID, MaxCount = info.MaxCount, CurrentCount = info.CurrentCount });
                    }
                }
            }

            return res;
        }
        private async Task<GetRoomsAccountPacketRes> HandleRoomInfos(AccountCommand<GetRoomsAccountPacketReq> message)
        {
            var res = new GetRoomsAccountPacketRes();

            var clusterLocator = new ClusterActorLocator(_actorSystem);

            var response = await clusterLocator.AskClusterActor<SA_GetAllRoomInfoResponse>(
                $"{TcpServerActorType.RoomManagerActor}",
                new AS_GetAllRoomInfoQuery(),
                TimeSpan.FromSeconds(50)
            );

            foreach (var info in response.RoomInfos)
            {
                res.RoomList.Add(new RoomInfo { RoomId = info.RoomID, MaxCount = info.MaxCount, CurrentCount = info.CurrentCount });
            }

            return res;
        }
    }
}
