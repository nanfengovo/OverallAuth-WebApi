using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Enum;


namespace Model
{
    /// <summary>
    /// 接口返回实体模型
    /// </summary>
    public class ReceiveStatus
    {
        /// <summary>
        /// 编码
        /// </summary>
        public CodeStatuEnum code { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public ReceiveStatus()
        {
            code = CodeStatuEnum.Successful;
            success = true;
            msg = "操作成功";
        }
    }
    /// <summary>
    /// 接口返回结果集
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ReceiveStatus<T> : ReceiveStatus
    {
        /// <summary>
        /// 数据
        /// </summary>
        public List<T> data { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        public int total { get; set; }
    }
}
