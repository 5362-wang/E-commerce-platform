using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dal.User
{
    public class UserTypeinfoDal
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 添加用户状态
        /// </summary>
        /// <returns></returns>
        public int Add(UserTypeInfo u)
        {
            string sql = string.Format("insert into UserTypeInfo values('{0}')", u.UserTypeName);
            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 删除用户状态
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Del(int Id)
        {
            string sql = $"delect from UserTypeInfo where Id = {Id}";
            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int Upt(UserTypeInfo u)
        {
            string sql = string.Format("update UserTypeInfo set UserTypeName='{0}' where Id='{1}'", u.UserTypeName,u.UserTypeId);
            return db.ExecuteNonQuery(sql);
        }
        
    }
}
