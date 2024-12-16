using Infrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    /// <summary>
    /// 用户仓储服务接口实现
    /// </summary>
    internal class SysUserRepository : ISysUserRepository
    {
        /// <summary>
        /// 测试Autofac
        /// </summary>
        /// <returns></returns>
        public string TestAutofac()
        {
            return "Autofac使用成功！";
        }
    }
}
