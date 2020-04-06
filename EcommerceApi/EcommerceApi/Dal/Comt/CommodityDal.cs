using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace Dal.Comt
{
    public class CommodityDal
    {
        /// <summary>
        /// 连接数据库
        /// </summary>
        public string Conn = "Data Source=LAPTOP-F4Q9118Q;Initial Catalog=EWTP;Integrated Security=True";

        /// <summary>
        /// 添加颜色
        /// </summary>
        /// <returns></returns>
        public int ColorAdd(string color)
        {

            int res = 0;
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                var sql = $"insert into CommodityColor(Color) values('{color}')";
                res = connection.Execute(sql);
            }
            return res;

        }
        /// <summary>
        /// 显示颜色
        /// </summary>
        /// <returns></returns>
        public List<CommodityColor> ColorShow()
        {
            var list = new List<CommodityColor>();
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                var sql = "select * from CommodityColor";
                list = connection.Query<CommodityColor>(sql).ToList();
            }
            return list;
        }
        public string ColorUpt()
        {
            string res = "";
            return res;
        }


        /// <summary>
        /// 添加商品
        /// </summary>
        /// <returns></returns>
        public int CommodityAdd(CommodityInfo Info)
        {
            int res = 0;
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                var sql = $"insert into CommodityInfo(CommodName,SystematicId,CommodityImg,CommodityPrice,CommodityDetalis,RegisterDate,PutNumber,CountNumber) values ('{Info.CommodName}','{Info.SystematicId}','{Info.CommodityImg}','{Info.CommodityPrice}','{Info.CommodityDetalis}',1,'{Info.PutNumber}','{Info.CountNumber}')";
                res = connection.Execute(sql);

            }
            return res;

        }
        /// <summary>
        /// 修改状态
        /// </summary>
        /// <returns></returns>
        public int CommodityUpt(int id = 0)
        {
            int res = 0;
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                var sql = $"Update  CommodityInfo    set   RegisterDate=0    where  CommodityId={id}";
                res = connection.Execute(sql);
            }
            return res;
        }

        /// <summary>
        /// 根据用户id获取单条信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CommodityInfo GetOneCommodityInfo(int id = 0)
        {
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Query<CommodityInfo>("select * from CommodityInfo where CommodityId=" + id).Single();
            }
        }

        /// <summary>
        /// 编辑方法
        /// </summary>
        /// <param name="info"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateCommodityInfo(CommodityInfo info)
        {

            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Execute(string.Format($@"update CommodityInfo set CommodName='{info.CommodName}',
                                                            SystematicId={info.SystematicId},
                                                            CommodityImg='{info.CommodityImg}',
                                                            CommodityPrice='{info.CommodityPrice}',
                                                            CommodityDetalis='{info.CommodityDetalis}',
                                                            RegisterDate='{info.RegisterDate}',
                                                            PutNumber='{info.PutNumber}',
                                                            CountNumber='{info.CountNumber}' where CommodityId={info.CommodityId}"));
            }
        }

        /// <summary>
        /// 获取单条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CommodityInfo OneCommosity(int id = 0)
        {
            CommodityInfo info = new CommodityInfo();
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                var sql = "select * from CommodityInfo where CommodityId='{id}'";
                info = connection.Query<CommodityInfo>(sql).FirstOrDefault();
            }
            return info;
        }


        /// <summary>                                                              
        /// 显示商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public List<CommodityInfo> CommodityShow(string name, int CtypeId = 0)
        {
            var list = new List<CommodityInfo>();
            string sql;
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                sql = @"select * from CommodityInfo as c join CommodityType as t on t.CtypeId=c.SystematicId where c.SystematicId>0";
                if (!string.IsNullOrEmpty(name))
                {
                    sql += $" and c.CommodName like '%{name}%'  ";
                }
                if (CtypeId > 0)
                {
                    sql += " and c.SystematicId=" + CtypeId;
                }
                list = connection.Query<CommodityInfo>(sql).ToList();
            }
            return list;
        }
        /// <summary>                                                              
        /// 查询商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public CommodityInfo InquireCommodity(string name)
        {
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Query<CommodityInfo>("select * from CommodityInfo where CommodName='{name}'").FirstOrDefault();
            }
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CommodityDel(int id)
        {

            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Execute("update CommodityInfo set RegisterDate='{0}' ", id);

            }

        }




        /// <summary>
        /// 添加类别
        /// </summary>
        /// <returns></returns>
        public int TypeAdd(string type)
        {
            int res = 0;
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                var sql = $"insert into CommodityType(TypeName) values('{type}')";
                res = connection.Execute(sql);
            }
            return res;
        }

        /// <summary>
        /// 显示类别
        /// </summary>
        /// <returns></returns>
        public List<CommodityType> TypeShow()
        {
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Query<CommodityType>("select * from CommodityType").ToList();
            }
        }

    }
}
