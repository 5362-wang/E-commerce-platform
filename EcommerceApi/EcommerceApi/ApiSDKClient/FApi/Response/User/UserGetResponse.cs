using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace ApiSDKClient
{
    public class UserGetResponse : BaseResponse
    {
        public List<UserInfo> UserInfoList { get; set; }

        public UserInfo info { get; set; }
    }
}
