using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class OrderGetRequest : BaseRequest
    {
        /// <summary>
        /// 查询需要的名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 订单的类型
        /// </summary>
        public int OrderTypeId { get; set; }
        public override string GetApiName()
        {
            return "/api/Order/QueryOrderInfo";
        }
    }
}
