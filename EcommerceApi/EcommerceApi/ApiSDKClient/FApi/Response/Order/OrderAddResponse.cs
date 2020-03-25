using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    public class OrderAddResponse:BaseResponse
    {
        /// <summary>
        /// 是否添加成功
        /// </summary>
        public int IsAddSuccess { get; set; }
    }
}
