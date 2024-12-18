using Infrastructure.IRepository.Sys;
using Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Sys
{
    /// <summary>
    /// 系统菜单仓储接口实现
    /// </summary>
    public class SysMenuRepository : Repository<SysMenu>, ISysMenuRepository
    {
    }
}
