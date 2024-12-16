using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.BusinessModel.InPut;
using OverallAuth_WebApi.PlugInUnit;
using Utility.Enum;

namespace OverallAuth_WebApi.Controllers
{
    /// <summary>
    /// 用户模块
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = nameof(ModeuleGroupEnum.SysUser))]
    public class SysUserController : BaseController
    {
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        [HttpGet]
        [AllowAnonymous]
        public string GetToken(string userName, string password)
        {
            var loginResult = JwtPlugInUnit.BuildToken(new LoginInput { UserName = userName, Password = password });

            return loginResult.Token ?? string.Empty;
        }
    }
}
