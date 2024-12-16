using DomainService.IService;
using Infrastructure;
using Infrastructure.IRepository;
using Model.DomainModel;
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

        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns></returns>
        public List<SysUser> GetAllUser()
        {
            return _sysUserRepository.GetAll(BaseSqlRepository.sysUser_selectAllSql);
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
