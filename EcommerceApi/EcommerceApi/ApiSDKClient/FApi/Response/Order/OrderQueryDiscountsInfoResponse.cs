using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class OrderQueryDiscountsInfoResponse : BaseResponse
    {
        public List<DiscountsInfo> QueryDiscountsInfo { get; set; }
    }
}
