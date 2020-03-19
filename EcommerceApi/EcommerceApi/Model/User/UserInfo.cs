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
        public int UserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName	 { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPass	 { get; set; }
        /// <summary>
        /// 盐 做密码加密
        /// </summary>
        public string Salt		 { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>

        public string NickName	 { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string UserImg		 { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string PhoneNumder	 { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName	 { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public int Province	 { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public int City		 { get; set; }
        /// <summary>
        /// 区域
        /// </summary>
        public int Area		 { get; set; }
        /// <summary>
        /// 用户详细地址
        /// </summary>
        public string AddDetail	 { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email		 { get; set; }
        /// <summary>
        /// 用户余额
        /// </summary>
        public decimal UserMoney	 { get; set; }
        /// <summary>
        /// 用户状态
        /// </summary>
        public int UserType	 { get; set; }
        /// <summary>
        /// 表示状态
        /// </summary>
        public int Status       { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime	 { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime	 { get; set; }
        /// <summary>
        /// 创建人id
        /// </summary>
        public int CreaterId	 { get; set; }
        /// <summary>
        /// 修改人id
        /// </summary>
        public int UpdaterId	 { get; set; }
    }
}
