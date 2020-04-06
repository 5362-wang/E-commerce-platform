using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Comt
{
    /// <summary>
    /// 删除商品
    /// </summary>
   public class CommodityDelRequest:BaseRequest
    {
        public int id { get; set; }
        public override string GetApiName()
        {
            return "/api/Commodity/CommodityDel";
        }
    }
}
