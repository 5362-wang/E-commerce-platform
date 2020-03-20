using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 优惠信息表
    /// </summary>
    public class DiscountsInfo
    {
        /// <summary>
        /// 优惠编号
        /// </summary>
        public int DiscountsId { get; set; }
        /// <summary>
        /// 优惠方式
        /// </summary>
        public string DiscountsWay { get; set; }
    }
}
