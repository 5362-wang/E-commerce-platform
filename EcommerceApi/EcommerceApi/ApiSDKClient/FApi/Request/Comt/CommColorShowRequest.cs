﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Comt
{
    /// <summary>
    /// 显示颜色
    /// </summary>
    public class CommColorShowRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/Commodity/ShowColor";
        }
    }
}
