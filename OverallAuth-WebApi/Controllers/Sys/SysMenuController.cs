using DomainService.IService.Sys;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.BusinessModel.OutPut;
using Model;
using Utility.Enum;

namespace OverallAuth_WebApi.Controllers.Sys
{
    /// <summary>
    /// 系统模块
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = nameof(ModeuleGroupEnum.SysMenu))]
    public class SysMenuController : BaseController
    {

        #region 构造实列化

        /// <summary>
        /// 菜单服务服务
        /// </summary>
        public ISysMenuService _sysMenuService;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="sysMenuService"></param>
        public SysMenuController(ISysMenuService sysMenuService)
        {
            _sysMenuService = sysMenuService;
        }

        #endregion

        #region 菜单接口

        /// <summary>
        /// 获取树形菜单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ReceiveStatus<SysMenuOutPut> GetMenuTreeList()
        {
            ReceiveStatus<SysMenuOutPut> receiveStatus = new();
            var list = _sysMenuService.GetMenuTreeList();
            receiveStatus.data = list;
            return receiveStatus;
        }

        #endregion

    }
}
