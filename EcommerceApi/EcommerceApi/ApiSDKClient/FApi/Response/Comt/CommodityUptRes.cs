using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Response.Comt
{
    /// <summary>
    /// 获取单条信息
    /// </summary>
   public class CommodityUptRes : BaseResponse
    {
        public CommodityInfo CommUpt { get; set; }
    }
}
