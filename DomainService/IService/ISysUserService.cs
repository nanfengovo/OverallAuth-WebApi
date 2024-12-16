using Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.IService
{
    /// <summary>
    /// 用户服务接口
    /// </summary>
   public interface ISysUserService
    {
        /// <summary>
        /// 测试autofac
        /// </summary>
        /// <returns></returns>
        string TestAutofac();

        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        List<SysUser> GetAllUser();
    }
}
