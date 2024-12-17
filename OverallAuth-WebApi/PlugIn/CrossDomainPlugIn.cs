using OverallAuth_WebApi.PlugInUnit;

namespace OverallAuth_WebApi.PlugIn
{
    /// <summary>
    /// 跨域配置插件
    /// </summary>
    public static class CrossDomainPlugIn
    {
        /// <summary>
        /// 跨域
        /// </summary>
        /// <param name="services"></param>
        public static void InitCors(this IServiceCollection services)
        {
            //允许一个或多个来源可以跨域
            services.AddCors(options =>
            {
                options.AddPolicy("Access-Control-Allow-Origin", policy =>
                {
                    var result = AppSettingsPlugIn.GetNode("CustomCorsPolicy:WhiteList").Split(',');
                    // 设定允许跨域的来源，有多个可以用','隔开
                    policy.WithOrigins(result)
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });
            });
        }
    }
}
