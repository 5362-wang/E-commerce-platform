using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class OrderQueryCommodityTypeRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "api/Order/QueryCommodityType";
        }
    }
}
