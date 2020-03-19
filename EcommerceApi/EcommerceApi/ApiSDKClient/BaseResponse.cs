using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    /// <summary>
    /// 返回的基类
    /// </summary>
    public class BaseResponse
    {
        /// <summary>
        /// 状态为true  表示接口请求成功了
        /// </summary>
        public bool Status = true;

        /// <summary>
        /// 当状态失败时，提示消息
        /// </summary>
        public string Message { get; set; }
    }
}
