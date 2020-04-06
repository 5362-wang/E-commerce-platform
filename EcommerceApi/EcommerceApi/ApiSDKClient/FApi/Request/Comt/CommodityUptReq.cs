using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Comt
{
    /// <summary>
    /// 获取单条信息
    /// </summary>
    public class CommodityUptReq : BaseRequest
    {
        public int Id { get; set; }
        public override string GetApiName()
        {
            return "/api/Commodity/GetCommodityInfo";
        }
    }
}
