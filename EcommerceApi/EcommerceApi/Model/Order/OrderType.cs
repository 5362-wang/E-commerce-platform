using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 订单状态类型表
    /// </summary>
    public class OrderType
    {
        /// <summary>
        /// 订单类别编号
        /// </summary>
        public int OrderTypeId { get; set; }
        /// <summary>
        /// 订单类别名称
        /// </summary>
        public string OrderTypeName { get; set; }
    }
}
