using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Comt
{
    /// <summary>
    /// 添加类别
    /// </summary>
   public class CommTypeAddRequest   :BaseRequest
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        public int TypeName { get; set; }
        public override string GetApiName()
        {
            return "/api/Comt/TypeAdd";
        }
    }
}
