using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using OverallAuth_WebApi.Model;
using System.Text;

namespace OverallAuth_WebApi.PlugInUnit
{
    /// <summary>
    /// jwt插件
    /// </summary>
    public static class JwtPlugInUnit
    {
        /// <summary>
        /// 初始化JWT
        /// </summary>
        /// <param name="services"></param>
        public static void InitJWT(this IServiceCollection services)
        {
            var jwtsetting = AppSettingsPlugInUnit.GetNode<JwtSettingModel>("JwtSetting");
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(o =>
                {
                    o.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = jwtsetting.Issuer,
                        ValidAudience = jwtsetting.Audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtsetting.SecurityKey)),
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                });
        }
    }
}
