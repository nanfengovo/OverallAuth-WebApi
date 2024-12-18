using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessModel.OutPut
{
    /// <summary>
    /// 菜单输出模型
    /// </summary>
    public class SysMenuOutPut
    {
        /// <summary>
        /// 菜单主键
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 上级菜单
        /// </summary>
        public string? Pid { get; set; }

        /// <summary>
        /// 公司key
        /// </summary>
        public string? CorporationKey { get; set; }

        /// <summary>
        /// 系统Key
        /// </summary>
        public string? SystemKey { get; set; }

        /// <summary>
        /// 菜单路径
        /// </summary>
        public string? Path { get; set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        public string? MenuIcon { get; set; }

        /// <summary>
        /// 菜单标题
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 菜单模板
        /// </summary>
        public string? Component { get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人员
        /// </summary>
        public string? CreateUser { get; set; }

        /// <summary>
        /// 是否验证
        /// </summary>
        public bool RequireAuth { get; set; }

        /// <summary>
        /// 重定向目录
        /// </summary>
        public string? Redirect { get; set; }

        /// <summary>
        /// 子节点
        /// </summary>
        public List<SysMenuOutPut>? Children { get; set; }
    }
}
