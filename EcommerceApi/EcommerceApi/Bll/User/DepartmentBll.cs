using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.User;
using Model;

namespace Bll.User
{
    class DepartmentBll
    {
        DepartmentDal dal = new DepartmentDal();
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <returns></returns>
        public int Add(Department d)
        {

            return dal.Add(d);
        }
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Del(int Id)
        {
            return dal.Del(Id);
        }
        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int Upt(Department d)
        {
            return dal.Upt(d);
        }
        /// <summary>
        /// 显示部门
        /// </summary>
        /// <returns></returns>
        public List<Department> Get()
        {
            return dal.Get();
        }
    }
}
