using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Model;
using System.Data.SqlClient;
namespace Dal.User
{
    public class UserDal
    {
        public string ConnStr = "Data Source=.;Initial Catalog=EWTP;Integrated Security=True";
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int UserRegist( UserInfo userInfo)
        {
            int res = 0;
            using (IDbConnection connection= new  SqlConnection (ConnStr))
            {
                var sql = $@"INSERT INTO [dbo].[UserInfo]
           ([UserName]
           ,[PassWord]
           ,[Phone]
           ,[Email]
           ,[Salt]
           ,[RealName]
           ,[DepartmentId]
           ,[UserImg]
           ,[UserType])
            VALUES
           ('{userInfo.UserName}',
           '{userInfo.PassWord}',
           '{userInfo.Phone}',
           '请绑定邮箱',
           '{userInfo.Salt}',
           '请输入真实姓名',
          0,
          '222',
           1)";
                res = connection.Execute(sql);
            }

            return res;
        }
        /// <summary>
        /// 判断用户是否重复
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public  bool IsExistPhone (string username)
        {
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                string sql = $"Select count(1) From UserInfo Where UserName='{username}'";
                return connection.ExecuteScalar<int>(sql) > 0;
            }
           
        }

        public UserInfo  UserLogin(string username,string pwd)
        {
            UserInfo info = new UserInfo();
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                var sql = $"select * from UserInfo as u join Department as d on  u.DepartmentId=d.DepartmentId where UserName='{username}'and PassWord='{pwd}'";
                info = connection.Query<UserInfo>(sql).FirstOrDefault();
            }
            return info;
        }
        public int FindPwd(string userName,string pwd)
        {
            int res = 0;
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                var sql = $"update [dbo].[UserInfo]  set PassWord='{pwd}' where UserName='{userName}'";
                res = connection.Execute(sql);
            }
            return res;
        }
        public List<UserInfo> GetUsers()
        {
            List<UserInfo> list = new List<UserInfo>();
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                var sql = "select * from UserInfo as u join Department as d on  u.DepartmentId=d.DepartmentId";
                list = connection.Query<UserInfo>(sql).ToList();
            }
            return list;
        }
        public UserInfo GetInfo(int id)
        {
            UserInfo info = new UserInfo();
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                var sql = "select * from UserInfo as u join Department as d on  u.DepartmentId=d.DepartmentId where Uid="+id;
               info = connection.Query<UserInfo>(sql).FirstOrDefault();
            }
            return info;
        }

    }
}
