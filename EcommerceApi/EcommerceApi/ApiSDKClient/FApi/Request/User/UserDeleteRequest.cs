using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class UserDeleteRequest : BaseRequest
    {


        public override string GetApiName()
        {
            return "/api/User/DeleteUserInfo";
        }
    }
}
