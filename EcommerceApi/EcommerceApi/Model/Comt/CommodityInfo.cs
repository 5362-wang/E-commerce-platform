using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 商品表
    /// </summary>
   public class CommodityInfo
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int CommodityId { get; set; }
        /// <summary>
        /// 商品分类
        /// </summary>
        public int SystematicId { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string CommodityImg { get; set; }
        /// <summary>
        /// 商品价钱
        /// </summary>
        public decimal CommodityPrice { get; set; }
        /// <summary>
        /// 商品详情
        /// </summary>
        public string CommodityDetalis { get; set; }
        /// <summary>
        /// 上架状态
        /// </summary>
        public int RegisterDate { get; set; }
        /// <summary>
        /// 商品销售量
        /// </summary>
        public int PutNumber { get; set; }
        /// <summary>
        /// 商品库存
        /// </summary>
        public int CountNumber { get; set; }
    }
}
