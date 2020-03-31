using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dapper;
namespace Dal.Order
{
    public class OrderDal
    {
        public string ConnStr = "Data Source=.;Initial Catalog=EWTP;Integrated Security=True";

        /// <summary>
        /// 查询订单表（并且可根据订单类型【快递到哪了】和商品名称进行查询）
        /// </summary>
        /// <param name="name"></param>
        /// <param name="OrderTypeId"></param>
        /// <returns></returns>
        public List<OrderInfo> QueryOrderInfo(string name, int OrderTypeId = 0)
        {
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                string sql;

                List<OrderInfo> list = new List<OrderInfo>();
                sql = $@"select * from OrderInfo as o
                                                    join DiscountsInfo as d
                                                    on o.YhId = d.DiscountsId
                                                    join OrderType as t
                                                    on t.OrderTypeId = o.OrderTypeId
                                                    join CommodityType as c
                                                    on c.CtypeId = o.OrderTypeId where  o.Staus > 0";

                if (!string.IsNullOrEmpty(name))
                {
                    sql += $" and o.OrderName like '%+{name}+%'  ";
                }
                if (OrderTypeId > 0)
                {
                    sql += " and o.OrderTypeId=" + OrderTypeId;
                }

                list = connection.Query<OrderInfo>(sql).ToList();
                return list;
            }
        }
        /// <summary>
        /// 查询优惠信息表[9折  7折  5折  免单]
        /// </summary>
        /// <returns></returns>
        public List<DiscountsInfo> QueryDiscountsInfo()
        {
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                return connection.Query<DiscountsInfo>("select * from DiscountsInfo").ToList();
            }
        }
        /// <summary>
        /// 查询商品规格表[S  M  L  XL]
        /// </summary>
        /// <returns></returns>
        public List<CommodityType> QueryCommodityType()
        {
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                return connection.Query<CommodityType>("select * from CommodityType").ToList();
            }
        }
        /// <summary>
        /// 查询订单类型表[看快递走到哪了]
        /// </summary>
        /// <returns></returns>
        public List<OrderType> QueryOrderType()
        {
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                return connection.Query<OrderType>("select * from OrderType").ToList();
            }
        }
        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AddOrderInfo(OrderInfo info)
        {
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                return connection.Execute(string.Format(@"insert into OrderInfo(BoughtTime,OrderName,CommodityImg,OrderSize,OrderCount,YhId,OrderPrice,OrderTypeId,Consignee,ConsigneeTel,Staus,CreateId,UpdateId,CreateTime,UpdateTime) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')"
                                            , info.BoughtTime, info.OrderName, info.CommodityImg, info.OrderSize, info.OrderCount, info.YhId, info.OrderPrice, info.OrderTypeId, info.Consignee,
                                            info.ConsigneeTel, info.Staus, info.CreateId, info.UpdateId, info.CreateTime, info.UpdateTime));
            }
        }

        /// <summary>
        /// 逻辑删除订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelOrderInfo(int id = 0)
        {
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                return connection.Execute("update OrderInfo set Staus=0 where OrderId=" + id);
            }
        }

        /// <summary>
        /// 根据用户id获取单条信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderInfo GetOneOrderInfo(int id = 0)
        {
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                return connection.Query<OrderInfo>("select * from OrderInfo where OrderId='{0}'", id).Single();
            }
        }

        /// <summary>
        /// 编辑方法
        /// </summary>
        /// <param name="info"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateOrderInfo(OrderInfo info)
        {

            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                return connection.Execute(string.Format($@"update OrderInfo set BoughtTime='{info.BoughtTime}',
                                                            OrderName='{info.OrderName}',
                                                            CommodityImg='{info.CommodityImg}',
                                                            OrderSize='{info.OrderSize}',
                                                            OrderCount='{info.OrderCount}',
                                                            YhId='{info.YhId}',
                                                            YhId,OrderPrice='{info.OrderPrice}',
                                                            OrderTypeId='{info.OrderTypeId}',
                                                            Consignee='{info.Consignee}',
                                                            ConsigneeTel='{info.ConsigneeTel}',
                                                            Staus='{info.Staus}',
                                                            CreateId='{info.CreateId}',
                                                            UpdateId='{info.UpdateId}',
                                                            CreateTime='{info.CreateTime}',
                                                            UpdateTime='{info.UpdateTime}' where OrderId='{info.OrderId}'"));
            }
        }
    }
}
