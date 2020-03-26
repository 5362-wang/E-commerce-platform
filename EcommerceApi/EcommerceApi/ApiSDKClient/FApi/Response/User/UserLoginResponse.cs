using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
   public  class UserLoginResponse: BaseResponse
    {
        /// <summary>
        /// 是否登录成功
        /// </summary>
        public bool LoginSuccess { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户部门
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string UserImg { get; set; }
    }
}
