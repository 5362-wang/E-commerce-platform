using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class OrderUpdateStausGoGoodsRequest : BaseRequest
    {
        public int OrderId { get; set; }

        public override string GetApiName()
        {
            return "/api/Order/UpdateStausGoGoods";
        }
    }
}
