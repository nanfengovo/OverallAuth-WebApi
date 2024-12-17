
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

            //注册Autofac
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule(new AutofacPlugIn());
            });


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //自定义swagger中间件
            builder.Services.InitSwagger();

            //自定义JWT中间件
            builder.Services.InitJWT();

            //自定义全局异常处理
            builder.Services.AddControllers(a =>
            {
                a.Filters.Add(typeof(ExceptionPlugIn));
            });

            //跨域配置
            builder.Services.InitCors();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();
                app.InitSwagger();
            }

            //认证中间件
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCors("Access-Control-Allow-Origin");

            app.MapControllers();

            app.Run();
        }
    }
}
