using System;

namespace Model
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class OrderInfo
    {

        /// <summary>
        /// 订单编号
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// 订单处理时间
        /// </summary>
        public DateTime BoughtTime { get; set; }
        /// <summary>
        /// 订单名称
        /// </summary>
        public string OrderName { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string CommodityImg { get; set; }
        /// <summary>
        /// 订单规格
        /// </summary>
        public int OrderSize { get; set; }
        /// <summary>
        /// 订单数量
        /// </summary>
        public int OrderCount { get; set; }
        /// <summary>
        /// 优惠状态
        /// </summary>
        public int YhId { get; set; }
        /// <summary>
        /// 订单价格
        /// </summary>
        public decimal OrderPrice { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        public int OrderTypeId { get; set; }
        /// <summary>
        /// 收货人
        /// </summary>
        public string Consignee { get; set; }
        /// <summary>
        /// 收货人电话
        /// </summary>
        public string ConsigneeTel { get; set; }
        /// <summary>
        /// 快递方式
        /// </summary>
        public int ExpressageId { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public int Staus { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public int CreateId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public int UpdateId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 优惠名称
        /// </summary>
        public string DiscountsWay { get; set; }
        /// <summary>
        /// 订单状态类型
        /// </summary>
        public string OrderTypeName { get; set; }
    }
}
