using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Comt
{
    /// <summary>
    /// 查询商品
    /// </summary>
   public class CommodityInquireRequest :BaseRequest
    {
        public bool CommodName { get; set; }
        public override string GetApiName()
        {
            return "/api/Commodity/CommodityInquire";
        }
    }
}
