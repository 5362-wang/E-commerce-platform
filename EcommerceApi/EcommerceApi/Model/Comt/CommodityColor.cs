using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 商品颜色表
    /// </summary>
   public class CommodityColor
    {
        /// <summary>
        /// 颜色Id
        /// </summary>
        public int CommodityId { get; set; }
        /// <summary>
        /// 颜色名称
        /// </summary>
        public string Color { get; set; }
    }
}
