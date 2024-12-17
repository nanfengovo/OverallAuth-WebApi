using Model.BusinessModel.OutPut;
using Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IRepository
{
    /// <summary>
    /// 用户服务仓储接口
    /// </summary>
    public interface ISysUserRepository:IRepository<SysUser>
    {
        /// <summary>
        /// Autofac测试
        /// </summary>
        /// <returns></returns>
        string TestAutofac();

        /// <summary>
        /// 根据用户名和密码获取用户
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public SysUser? GetUserMsg(string username ,string password);



    }
}
