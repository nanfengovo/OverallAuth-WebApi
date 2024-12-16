using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    /// <summary>
    /// 创建继承sql仓储
    /// </summary>
    public class BaseSqlRepository
    {
        #region 表Sys_user

        /// <summary>
        /// sys_user新增
        /// </summary>
        public static string sysUser_insertSql = @"insert into Sys_User (UserName ,Password ,Age,Sex,IsOpen,DepartmentId,CreateTime,CreateUser) values(@UserName ,@Password ,@Age,@Sex,@IsOpen,@DepartmentId,@CreateTime,@CreateUser)";

        /// <summary>
        /// sys_user更新
        /// </summary>
        public static string sysUser_updateSql = @"update Sys_User set UserName=@UserName ,Password=@Password ,Age=@Age,Sex=@Sex,DepartmentId=@DepartmentId,CreateTime=@CreateTime,CreateUser=@CreateUser where UserId = @UserId";

        /// <summary>
        /// sys_user查询
        /// </summary>
        public static string sysUser_selectByKeySql = @" select * from Sys_User where  UserId=@Key";

        /// <summary>
        /// sys_user表查询全部语句
        /// </summary>
        public static string sysUser_selectAllSql = @" select * from Sys_User";

        #endregion
    }
}
