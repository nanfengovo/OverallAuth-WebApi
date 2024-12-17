using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Model.BusinessModel.InPut;
using Model.BusinessModel.OutPut;
using OverallAuth_WebApi.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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
            var jwtsetting = AppSettingsPlugIn.GetNode<JwtSettingModel>("JwtSetting");
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


        /// <summary>
        /// 反射获取字段
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static IEnumerable<(string Name, object Value, string Type)> PropValuesType(this object obj)
        {
            List<(string a, object b, string c)> result = new List<(string a, object b, string c)>();

            var type = obj.GetType();
            var props = type.GetProperties();
            foreach (var item in props)
            {
                result.Add((item.Name, item.GetValue(obj), item.PropertyType.Name));
            }
            return result;
        }


        /// <summary>
        /// 生成Token
        /// </summary>
        /// <param name="loginResult">登陆返回信息</param>
        /// <returns></returns>
        public static LoginOutPut BuildToken(LoginInput loginResult)
        {
            LoginOutPut result = new LoginOutPut();
            //获取配置
            var jwtsetting = AppSettingsPlugIn.GetNode<JwtSettingModel>("JwtSetting");

            //准备calims，记录登录信息
            var calims = loginResult.PropValuesType().Select(x => new Claim(x.Name, x.Value.ToString(), x.Type)).ToList();

            //创建header
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtsetting.SecurityKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(creds);

            //创建payload
            var payload = new JwtPayload(jwtsetting.Issuer, jwtsetting.Audience, calims, DateTime.Now, DateTime.Now.AddMinutes(jwtsetting.ExpireSeconds));

            //创建令牌 
            var token = new JwtSecurityToken(header, payload);
            var tokenStr = new JwtSecurityTokenHandler().WriteToken(token);
            result.ExpiresDate = token.ValidTo.AddHours(8).ToString();
            result.Token = tokenStr;
            result.UserName = loginResult.UserName;

            return result;
        }

    }
}
