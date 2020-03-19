using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    /// <summary>
    /// 添加用户的请求
    /// </summary>
    public class UserAddRequest : BaseRequest
    {
        public string UserName { get; set; }
        public string Pwd  { get; set; }
        public override string GetApiName()
        {
            return "/api/User/AddUser";
        }
    }
}
