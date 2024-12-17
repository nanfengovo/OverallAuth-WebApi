using Dapper;
using Infrastructure.DataBaseConnect;
using Infrastructure.IRepository;
using Model.DomainModel;
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
    internal class SysUserRepository : Repository<SysUser>, ISysUserRepository
    {
        /// <summary>
        /// 测试Autofac
        /// </summary>
        /// <returns></returns>
        public string TestAutofac()
        {
            return "Autofac使用成功！";
        }

        /// <summary>
        /// 根据用户名称和密码获取用户信息
        /// </summary>
        /// <param name="userName">用户名称</param>
        /// <param name="password">用户密码</param>
        /// <returns></returns>
        public SysUser? GetUserMsg(string userName, string password)
        {
            string sql = " select * from Sys_User where UserName =@UserName and Password=@Password";
            using var connection = DataBaseConnectConfig.GetSqlConnection();
            return connection.QueryFirstOrDefault<SysUser>(sql, new { UserName = userName, Password = password });
        }
    }
}
