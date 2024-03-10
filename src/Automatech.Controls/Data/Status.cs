using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatech.Controls.Data
{
    /// <summary>
    /// 状态定义
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// 未知状态
        /// </summary>
        None,

        /// <summary>
        /// 空闲
        /// </summary>
        Idle,

        /// <summary>
        /// 运行中
        /// </summary>
        Running,

        /// <summary>
        /// 紧停
        /// </summary>
        Estoped,
    }
}
