using Akka.AccountServer.AkkaDefine;
using Akka.AccountServer.DB;
using Akka.Actor;

using Microsoft.EntityFrameworkCore;

namespace Akka.AccountServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            #region ����ȯ�� ���� ������ 
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null; //���̽����� ���� �� ��ҹ��� ���� (PascalCase)
            });

            builder.WebHost.UseKestrel(options =>
            {
                options.ListenAnyIP(7022, listenOptions =>
                {
                    listenOptions.UseHttps();  // ���ÿ����� HTTPS ���
                });

                options.ListenLocalhost(5181, listenOptions =>
                {
                    listenOptions.UseHttps();
                });
            });
            #endregion

            #region db
            builder.Services.AddDbContext<AppDbContext>(options =>
                 options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            #endregion

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Akka
            // DI���  Controller.cs���� �����ڷ� ���� �� ����
            builder.Services.AddSingleton<IActorBridge, AkkaService>();

            // AkkaService ���� (Ŭ������ ���� ����)
            builder.Services.AddHostedService<AkkaService>(sp => (AkkaService)sp.GetRequiredService<IActorBridge>());
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
