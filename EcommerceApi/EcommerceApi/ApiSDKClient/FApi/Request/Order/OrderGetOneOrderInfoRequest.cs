﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    
    public class OrderGetOneOrderInfoRequest:BaseRequest
    {
        public int id { get; set; }
        public override string GetApiName()
        {
            return "api/Order/GetOneOrderInfo";
        }
    }
}
