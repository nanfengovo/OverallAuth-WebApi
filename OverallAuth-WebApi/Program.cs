
using Autofac;
using Autofac.Extensions.DependencyInjection;
using OverallAuth_WebApi.PlugIn;
using OverallAuth_WebApi.PlugInUnit;

namespace OverallAuth_WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //ע��Autofac
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule(new AutofacPlugIn());
            });


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //�Զ���swagger�м��
            builder.Services.InitSwagger();

            //�Զ���JWT�м��
            builder.Services.InitJWT();

            //�Զ���ȫ���쳣����
            builder.Services.AddControllers(a =>
            {
                a.Filters.Add(typeof(ExceptionPlugIn));
            });

            //��������
            builder.Services.InitCors();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();
                app.InitSwagger();
            }

            //��֤�м��
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCors("Access-Control-Allow-Origin");

            app.MapControllers();

            app.Run();
        }
    }
}
