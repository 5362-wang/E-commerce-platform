using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName	 { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPass	 { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 盐 做密码加密
        /// </summary>
        public string Salt		 { get; set; }
 
       
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 用户部门
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string UserImg { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        public int UserType	 { get; set; }


    }
}
