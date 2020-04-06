using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Response.Comt
{

    /// <summary>
    /// 获取一条信息
    /// </summary>
    public  class OneCommodityInfoResponse:BaseResponse
    {
        public CommodityInfo OneCommUpt { get; set; }
    }
}
