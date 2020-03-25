using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class OrderQueryDiscountsInfoRequest : BaseRequest
    {
        public override string GetApiName()
        {
            return "api/Order/QueryDiscountsInfo";
        }
    }
}
