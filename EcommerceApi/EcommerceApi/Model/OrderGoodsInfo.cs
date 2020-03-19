using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 订单商品信息
    /// </summary>
  public  class OrderGoodsInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 订单id
        /// </summary>
        public int OrderId		{ get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public int GoodsId		{ get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId		{ get; set; }
        /// <summary>
        /// 消费金额
        /// </summary>
        public decimal Price		{ get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public int OrserState { get; set; }
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
