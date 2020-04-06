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
    /// <summary>
    /// DAL
    /// </summary>
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
        public int ColorAdd(CommodityColor commodityColor)
        {
            
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Execute( "insert into CommodityColor(Color) values(@Color)", commodityColor);
            }
            
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
        /// <summary>
        /// 修改颜色
        /// </summary>
        /// <returns></returns>
        public int ColorUpt(CommodityColor color)
        {
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Execute("update CommodityColor set name=@Name", color);
            }
        }


        /// <summary>
        /// 添加商品
        /// </summary>
        /// <returns></returns>
        public int CommodityAdd(CommodityInfo commodityInfo)
        {
           
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Execute("insert into CommodityInfo(CommodityId,SystematicId,CommodityImg,CommodityPrice,CommodityDetalis,RegisterDate,PutNumber,CountNumber) values (@CommodityId,@SystematicId,@CommodityImg,@CommodityPrice,@CommodityDetalis,@RegisterDate,@PutNumber,@CountNumber)", commodityInfo);
               
            }
            
        }
        /// <summary>                                                              
        /// 显示商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public List<CommodityInfo> CommodityShow()
        {
            var list = new List<CommodityInfo>();
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                var sql = "select * from CommodityInfo ";
                list = connection.Query<CommodityInfo>(sql).ToList();
            }
            return list;
        }
        /// <summary>                                                              
        /// 查询商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public CommodityInfo InquireCommodity(CommodityInfo info)
        {
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                  return connection.Query< CommodityInfo > ("select * from CommodityInfo where CommodName=@CommodName",info).SingleOrDefault();
            }
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CommodityDel(CommodityInfo info)
        {
          
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Execute("update CommodityInfo set RegisterDate=@RegisterDate ",info);
                
            }
          
        }

        /// <summary>
        /// 编辑商品
        /// </summary>
        /// <returns></returns>
        public int CommodityUpt(CommodityInfo info)
        {
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Execute( "update CommodityInfo set CommodityId=@CommodityId ",info);
            }
        }

        /// <summary>
        /// 添加类别
        /// </summary>
        /// <returns></returns>
        public int TypeAdd(CommodityType commodityType)
        {
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                return connection.Execute("insert into CommodityType(TypeName) values (@TypeNamw)", commodityType);
            }
        }

        /// <summary>
        /// 显示类别
        /// </summary>
        /// <returns></returns>
        public List<CommodityType> TypeShow()
        {
            var list = new List<CommodityType>();
            using (IDbConnection connection = new SqlConnection(Conn))
            {
                var sql = "select * from CommodityType";
                list = connection.Query<CommodityType>(sql).ToList();
            }
            return list;
        }

    }
}
