using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.User;
using Model;


namespace Bll.User
{

    class UserTypeInfoBll
    {
        UserTypeinfoDal dal = new UserTypeinfoDal();
        /// <summary>
        /// 添加用户状态
        /// </summary>
        /// <returns></returns>
        public int Add(UserTypeInfo u)
        {
            return dal.Add(u);
        }
        /// <summary>
        /// 删除用户状态
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Del(int Id)
        {
            return dal.Del(Id);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int Upt(UserTypeInfo u)
        {
            return dal.Upt(u);
        }
    }
}
