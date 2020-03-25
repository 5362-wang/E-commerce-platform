using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class OrderDeleteRequest : BaseRequest
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        public override string GetApiName()
        {
            return "/api/Order/DelOrderInfo";
        }
    }
}
