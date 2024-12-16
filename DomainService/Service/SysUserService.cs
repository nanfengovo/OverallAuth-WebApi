using DomainService.IService;
using Infrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service
{
    internal class SysUserService : ISysUserService
    {
        #region 构造实例化
        public readonly ISysUserRepository _sysUserRepository;
        public SysUserService(ISysUserRepository sysUserRepository)
        {
            _sysUserRepository = sysUserRepository;
        }
        #endregion

        /// <summary>
        /// 测试TestAutofac
        /// </summary>
        /// <returns></returns>
        public string TestAutofac()
        {
            return _sysUserRepository.TestAutofac();
        }
    }
}
