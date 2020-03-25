using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class OrderUpdateResponse : BaseResponse
    {
        /// <summary>
        /// 是否修改成功
        /// </summary>
        public int IsUpdateSuccess { get; set; }
    }
}
