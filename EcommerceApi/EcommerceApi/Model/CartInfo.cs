using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 购物车信息
    /// </summary>
    public class CartInfo
    {
        /// <summary>
        /// 购物车编号
        /// </summary>
        public int CartId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId		 { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public int GoodsId		 { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName	 { get; set; }
        /// <summary>
        /// 商品主图
        /// </summary>
        public string GoodsImg	 { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int CartCount	 { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price		 { get; set; }
        /// <summary>
        /// 表示状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 创建人id
        /// </summary>
        public int CreaterId { get; set; }
        /// <summary>
        /// 修改人id
        /// </summary>
        public int UpdaterId { get; set; }
    }
}
