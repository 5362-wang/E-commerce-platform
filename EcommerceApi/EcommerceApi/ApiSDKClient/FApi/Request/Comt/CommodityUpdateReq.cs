using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Comt
{
    /// <summary>
    /// 修改商品信息
    /// </summary>
    public class CommodityUpdateReq : BaseRequest
    {

        /// <summary>
        /// 商品Id
        /// </summary>
        public int CommodityId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string CommodName { get; set; }
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
        public override string GetApiName()
        {
            return "/api/Commodity/UpdateCommodityInfo";
        }
    }
}
