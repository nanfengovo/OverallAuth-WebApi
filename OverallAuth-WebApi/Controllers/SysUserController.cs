using DomainService.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.BusinessModel.InPut;
using Model.DomainModel;
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

        #region 构造实例化
        /// <summary>
        /// 用户服务
        /// </summary>
        public readonly ISysUserService _sysUserService;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="sysUserService">用户服务</param>
        public SysUserController(ISysUserService sysUserService)
        {
            _sysUserService = sysUserService;
        }
        #endregion

        /// <summary>
        /// 测试Autofac
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public String TestAutofac()
        {
            return _sysUserService.TestAutofac();
        }

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

        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public List<SysUser> GetAllUsers()
        {
            return _sysUserService.GetAllUser();
        }

        /// <summary>
        /// 测试异常
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet]
        [AllowAnonymous]
        public string TestException()
        {
            throw new Exception("系统发生异常");
        }
    }
}
