
using Microsoft.EntityFrameworkCore;
using WebApiWithEF.Models;
using WebApiWithEF.Controllers;

namespace WebApiWithEF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<ExamContext>(options =>
                       options.UseSqlServer(builder.Configuration.GetConnectionString("ExamContext")));

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

            app.UseAuthorization();


            app.MapControllers();

                        app.MapEmployeeEndpoints();

            app.Run();
        }
    }
}