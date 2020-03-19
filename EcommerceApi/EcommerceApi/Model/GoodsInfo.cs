using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 商品信息表
    /// </summary>
   public  class GoodsInfo
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        public int GoodsId { get; set; }
        /// <summary>
        /// 品牌编号
        /// </summary>
        public int BrandId		 { get; set; }
        /// <summary>
        /// 分类id
        /// </summary>
        public int CategoryId	 { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public int GoodsType	 { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName	 { get; set; }
        /// <summary>
        /// 商品主图
        /// </summary>
        public string GoodsPicture { get; set; }
        /// <summary>
        /// 商品简介
        /// </summary>
        public string GoodsBrief	 { get; set; }
        /// <summary>
        /// 商品介绍
        /// </summary>
        public string GoodsIntro	 { get; set; }
        /// <summary>
        /// 市场价格
        /// </summary>
        public decimal MarketPrice  { get; set; }
        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal SalePrice	 { get; set; }
        /// <summary>
        /// 成本价
        /// </summary>
        public decimal CostPrice	 { get; set; }
        /// <summary>
        /// 浏览量
        /// </summary>
        public int BrowseCount  { get; set; }
        /// <summary>
        /// 商品销量
        /// </summary>
        public int SaleCount	 { get; set; }
        /// <summary>
        /// 评论数
        /// </summary>
        public int CommentCount { get; set; }
        /// <summary>
        /// 收藏数量
        /// </summary>
        public int CollectCount { get; set; }
        /// <summary>
        /// 分享数量
        /// </summary>
        public int ShareCount   { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        public DateTime PutawayTime  { get; set; }
        /// <summary>
        /// 商品状态
        /// </summary>
        public int GoodsState   { get; set; }
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
