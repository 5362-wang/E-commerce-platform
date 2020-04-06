using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Comt
{
    /// <summary>
    /// 添加颜色
    /// </summary>
    public class CommColorAddRequest : BaseRequest
    {
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string Color { get; set; }
        public override string GetApiName()
        {
            return "/api/Commodity/AddColor";
        }

    }
}
