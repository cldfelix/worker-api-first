
using Microsoft.AspNetCore.Hosting;
using WebApiBackgroundServices.Repository;
using WebApiBackgroundServices.Services;

namespace WebApiBackgroundServices
{
    public class Program
    {
  
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
			
			builder.Services.AddHostedService<InfoWorker>();


            builder.Services.AddSingleton<ICommandRepository, CommandRepository>();
            builder.Services.AddSingleton<IMessageService, MessageService>();
            builder.Services.AddSingleton<IConsultaService, ConsultaService>();
            builder.Services.AddSingleton<IChatProService, ChatProService>();
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
