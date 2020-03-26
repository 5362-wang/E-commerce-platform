using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Response.Comt
{
   public class CommodityShowResponse :BaseResponse
    {
        public List<CommodityInfo> CommodityInfoSuccess { get; set; }
    }
}
