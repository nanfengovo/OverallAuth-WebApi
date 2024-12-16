using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Model.BusinessModel.OutPut;
using System.IdentityModel.Tokens.Jwt;
using Utility.Enum;

namespace OverallAuth_WebApi.Controllers
{
    /// <summary>
    /// 系统基础模块
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = nameof(ModeuleGroupEnum.Base))]
    [Authorize]
    public class BaseController : ControllerBase
    {
        /// <summary>
        /// 获取登陆人员信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public LoginOutPut GetLoginUserMsg()
        {
            StringValues s = new StringValues();
            var auth = Request.Headers.TryGetValue("Authorization", out s);
            if (string.IsNullOrWhiteSpace(s))
                throw new Exception("登录信息失效");
            var token = new JwtSecurityTokenHandler().ReadJwtToken(s.ToString().Replace($"{JwtBearerDefaults.AuthenticationScheme} ", ""));
            LoginOutPut loginResult = new()
            {
                UserName = token.Claims.FirstOrDefault(f => f.Type == "UserName").Value,
                Password = Convert.ToString(token.Claims.FirstOrDefault(f => f.Type == "Password").Value),
            };
            return loginResult;

        }
    }
}
