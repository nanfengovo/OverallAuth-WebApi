using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessModel.OutPut
{
    /// <summary>
    /// 登录输入模型
    /// </summary>
    public class LoginOutPut
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        public string? Token { get; set; }

        /// <summary>
        /// Token过期时间
        /// </summary>
        public string? ExpiresDate { get; set; }

    }
}
