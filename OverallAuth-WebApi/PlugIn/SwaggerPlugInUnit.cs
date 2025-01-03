﻿using Microsoft.OpenApi.Models;
using System.Reflection;
using Utility.Enum;

namespace OverallAuth_WebApi.PlugInUnit
{
    /// <summary>
    /// swagger插件
    /// </summary>
    public static class SwaggerPlugInUnit
    {
        /// <summary>
/// 初始化Swagger
/// </summary>
/// <param name="services"></param>
public static void InitSwagger(this IServiceCollection services)
{
    //添加swagger
    services.AddSwaggerGen(optinos =>
    {
        typeof(ModeuleGroupEnum).GetEnumNames().ToList().ForEach(version =>
        {
            optinos.SwaggerDoc(version, new OpenApiInfo()
            {
                Title = "权限管理系统",
                Version = "V2.0",
                Description = "求关注，求一键三连",
                Contact = new OpenApiContact { Name = "微信公众号作者：不只是码农   b站作者：我不是码农呢", Url = new Uri("http://www.baidu.com") }
            });

        });

        //反射获取接口及方法描述
        var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        optinos.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFileName), true);

        //使用jwt
        optinos.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = "请在下方输入框子输入Bearer Token 开启JWT鉴权",
            Name = "Authorization", // 默认名称，不能修改
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer"
        });

        //让swagger遵守jwt协议
        optinos.AddSecurityRequirement(new OpenApiSecurityRequirement
         {
           {
             new OpenApiSecurityScheme
             {
                Reference = new OpenApiReference
                {
                     Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
             },
            new List<string>()
            }
         });

    });
}
        /// <summary>
        /// swagger加入路由和管道
        /// </summary>
        /// <param name="app"></param>
        public static void InitSwagger(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                typeof(ModeuleGroupEnum).GetEnumNames().ToList().ForEach(versoin =>
                {
                    options.SwaggerEndpoint($"/swagger/{versoin}/swagger.json", $"接口分类{versoin}");
                });
            });
        }
    }
}
