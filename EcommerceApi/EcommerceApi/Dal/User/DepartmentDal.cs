using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dal.User
{
    public class DepartmentDal
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <returns></returns>
        public int Add(Department d)
        {
            string sql = string.Format("insert into DiscountsInfo values('{0}')", d.DiscountsWay);
            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Del(int Id)
        {
            string sql = $"delect from DiscountsInfo where Id = {Id}";
            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int Upt(Department d)
        {
            string sql = string.Format("update DiscountsInfo set DiscountsWay='{0}' where Id='{1}'", d.DiscountsWay, d.DiscountsId);
            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示部门
        /// </summary>
        /// <returns></returns>
        public List<Department> Get()
        {
            string sql = $"select * from DiscountsInfo";
            return db.GetToList<Department>(sql);
        }
    }
}
