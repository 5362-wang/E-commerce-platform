using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    /// <summary>
    /// 用户注册的返回
    /// </summary>
    public class UserAddResponse: BaseResponse
    {
        /// <summary>
        /// 是否注册成功
        /// </summary>
        public bool RegistSuccess { get; set; }
    }
}
