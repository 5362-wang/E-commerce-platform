using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Comt
{
    /// <summary>
    /// 修改上架状态
    /// </summary>
   public class CommodityUptRequest :BaseRequest
    {
        public int Id { get; set; }
        public override string GetApiName()
        {
            return "/api/Commodity/CommodityUpt";
        }
    }
}
