using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.Comt
{
    /// <summary>
    /// 显示类别
    /// </summary>
   public class CommTypeShowRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/Comt/TypeShow";
        }
    }
}
