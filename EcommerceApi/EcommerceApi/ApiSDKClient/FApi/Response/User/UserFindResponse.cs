using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class UserFindResponse: BaseResponse
    {
        /// <summary>
        /// 是否修改成功
        /// </summary>
        public bool FindSuccess { get; set; }
    }
}
