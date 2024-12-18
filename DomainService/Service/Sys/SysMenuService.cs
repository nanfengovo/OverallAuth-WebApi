using CoreDomain.BusinessCore;
using DomainService.IService.Sys;
using Infrastructure;
using Infrastructure.IRepository.Sys;
using Model.BusinessModel.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service.Sys
{
    /// <summary>
    /// 菜单服务实现
    /// </summary>
    public class SysMenuService : ISysMenuService
    {
        #region 构造实例化

        /// <summary>
        /// 菜单仓储接口
        /// </summary>
        private readonly ISysMenuRepository _menuRepository;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="menuRepository"></param>
        public SysMenuService(ISysMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        #endregion


        #region 业务逻辑

        /// <summary>
        /// 获取树形菜单
        /// </summary>
        /// <returns></returns>
        public List<SysMenuOutPut> GetMenuTreeList()
        {
            var menuList = _menuRepository.GetAll(BaseSqlRepository.sysMenu_selectAllSql);
            var menuTreeList = MenuCore.GetMenuTreeList(menuList);
            return menuTreeList;
        }

        #endregion
    }
}
