using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 订单信息表
    /// </summary>
    public class OrderInfo
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId			{ get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumser		{ get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public int OrderState		{ get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal TotalAmount		{ get; set; }
        /// <summary>
        /// 优惠卷id
        /// </summary>
        public int DiscountsId		{ get; set; }
        /// <summary>
        /// 促销id
        /// </summary>
        public int PromotionId		{ get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal DiscountAmount	{ get; set; }
        /// <summary>
        /// 支付金额
        /// </summary>
        public decimal PayAmount		{ get; set; }
        /// <summary>
        /// 收货人
        /// </summary>
        public string Reciver			{ get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public int ReciverProvince	{ get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public int ReciverCity     { get; set; }
        /// <summary>
        /// 区域
        /// </summary>
        public int ReciverArea     { get; set; }
        /// <summary>
        /// 用户详细地址
        /// </summary>
        public string ReciverAddDetail{ get; set; }
        /// <summary>
        /// 收货人电话
        /// </summary>
        public string ReciverPhone    { get; set; }
        /// <summary>
        /// 物流单号
        /// </summary>
        public string LogisticNumber  { get; set; }
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
