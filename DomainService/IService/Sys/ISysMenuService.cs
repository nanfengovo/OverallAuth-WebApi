using Model.BusinessModel.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.IService.Sys
{
    /// <summary>
    /// 菜单服务接口
    /// </summary>
    public interface ISysMenuService
    {
        /// <summary>
        /// 获取树形菜单
        /// </summary>
        /// <returns></returns>
        List<SysMenuOutPut> GetMenuTreeList();
    }
}
