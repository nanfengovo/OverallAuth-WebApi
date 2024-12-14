using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Utility.Enum;

namespace OverallAuth_WebApi.Controllers
{
    /// <summary>
    /// 系统模块
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = nameof(ModeuleGroupEnum.SysMenu))]
    public class SysMenuController : ControllerBase
    {
        /// <summary>
        /// 获取所有模块
        /// </summary>
        [HttpGet]
        public void GetAllMenu() { }



        /// <summary>
        /// 获取指定模块
        /// </summary>
        /// <param name="Id">模块Id</param>
        [HttpGet]
        public void GetMenuById(string Id) { }

        /// <summary>
        /// 检查jwt
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public string CheckJwt()
        {
            return "成功！";
        }

        /// <summary>
        /// 不检查jwt
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        public string UnCheckJwt()
        {
            return "成功";
        }
    }
}
