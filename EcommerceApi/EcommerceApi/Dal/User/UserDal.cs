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
        public string ConnStr = "Data Source=.;Initial Catalog=Commerce;Integrated Security=True";
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
                string sql = $@"INSERT INTO [dbo].[UserInfo]
           ([UserName]
           ,[UserPass]
           ,[Salt]
           ,[NickName]
           ,[UserImg]
           ,[PhoneNumder]
           ,[RealName]
           ,[Province]
           ,[City]
           ,[Area]
           ,[AddDetail]
           ,[Email]
           ,[UserMoney]
           ,[UserType]
           ,[Status]
           ,[CreateTime]
           ,[UpdateTime]
           ,[CreaterId]
           ,[UpdaterId])
     VALUES
           ('{userInfo.UserName}'
           ,'{userInfo.UserPass}'
           ,'{userInfo.Salt}'
           ,'{userInfo.NickName}'
           ,'0'
           ,'{userInfo.PhoneNumder}'
           ,'请填写真实姓名'
           ,0
           ,0
           ,0
           ,'请填写详细地址'
           ,'请绑定邮箱'
           ,0
           ,1
           ,1
           ,{DateTime.Now}
           ,{DateTime.Now}
           ,1
           ,1)";
                res = connection.Execute(sql);
            }

            return res;
        }
        /// <summary>
        /// 判断手机号是否重复
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public  bool IsExistPhone (string phone)
        {
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                string sql = $"Select count(1) From UserInfo Where PhoneNumder='{phone}' and Salt =1";
                return connection.ExecuteScalar<int>(sql) > 0;
            }
           
        }
    }
}
