﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Comt
{
    /// <summary>
    /// 显示商品
    /// </summary>
   public  class CommodityShowRequest :BaseRequest
    {
        public string name { get; set; }
        public int CtypeId { get; set; }
        public override string GetApiName()
        {
            return "/api/Commodity/CommodityShow";
        }
    }
}
