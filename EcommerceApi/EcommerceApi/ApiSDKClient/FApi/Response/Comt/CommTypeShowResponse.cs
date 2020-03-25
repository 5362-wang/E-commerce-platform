using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Response.Comt
{
   public class CommTypeShowResponse   :BaseResponse
    {
        public List<CommodityType> CommodityTypesSuccess { get; set; }
    }
}
