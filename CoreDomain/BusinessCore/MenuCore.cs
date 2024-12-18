using Model.BusinessModel.OutPut;
using Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDomain.BusinessCore
{
    /// <summary>
    /// 菜单核心
    /// </summary>
    public static class MenuCore
    {
        /// <summary>
        /// 递归获取菜单,组成树形结构
        /// </summary>
        /// <param name="menuList">菜单数据</param>
        /// <returns>返回菜单的树形结构</returns>
        public static List<SysMenuOutPut> GetMenuTreeList(List<SysMenu> menuList)
        {
            List<SysMenuOutPut> list = new();
            List<SysMenuOutPut> menuListDto = new();
            //模型的转换
            foreach (var item in menuList)
            {
                SysMenuOutPut model = new()
                {
                    Id = item.Id,
                    Pid = item.Pid,
                    CorporationKey = item.CorporationKey,
                    SystemKey = item.SystemKey,
                    Path = item.MenuUrl,
                    Name = item.MenuTitle,
                    MenuIcon = item.MenuIcon,
                    Component = item.Component,
                    IsOpen = item.IsOpen,
                    Sort = item.Sort,
                    RequireAuth = item.RequireAuth,
                    Redirect = item.Redirect,
                    CreateTime = item.CreateTime,
                    CreateUser = item.CreateUser,
                };
                list.Add(model);
            }
            //递归所有父级菜单
            foreach (var data in list.Where(f => f.Pid == "0" && f.IsOpen))
            {
                var childrenList = GetChildrenMenu(list, data.Id).OrderBy(f => f.Sort).ToList();
                data.Children = childrenList.Count == 0 ? null : childrenList;
                menuListDto.Add(data);
            }
            return menuListDto;
        }

        /// <summary>
        /// 实现递归
        /// </summary>
        /// <param name="moduleOutput">菜单数据</param>
        /// <param name="id">菜单ID</param>
        /// <returns></returns>
        private static List<SysMenuOutPut> GetChildrenMenu(List<SysMenuOutPut> moduleOutput, Guid id)
        {
            List<SysMenuOutPut> sysShowTempMenus = new();
            //得到子菜单
            var info = moduleOutput.Where(w => w.Pid == id.ToString() && w.IsOpen).ToList();
            //循环
            foreach (var sysMenuInfo in info)
            {
                var childrenList = GetChildrenMenu(moduleOutput, sysMenuInfo.Id);
                //把子菜单放到Children集合里
                sysMenuInfo.Children = childrenList.Count == 0 ? null : childrenList;
                //添加父级菜单
                sysShowTempMenus.Add(sysMenuInfo);
            }
            return sysShowTempMenus;
        }
    }
}
