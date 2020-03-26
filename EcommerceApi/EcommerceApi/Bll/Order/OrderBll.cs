using ApiSDKClient;
using Dal.Order;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bll.Order
{
    public class OrderBll:BaseBll<OrderBll>
    {
        OrderDal dal = new OrderDal();
        /// <summary>
        /// 查询订单表（并且可根据订单类型【快递到哪了】和商品名称进行查询）
        /// </summary>
        /// <param name="name"></param>
        /// <param name="OrderTypeId"></param>
        /// <returns></returns>
        public OrderGetResponse QueryOrderInfo(OrderGetRequest request)
        {
            OrderGetResponse response = new OrderGetResponse();
            return response;
        }
        /// <summary>
        /// 查询优惠信息表[9折  7折  5折  免单]
        /// </summary>
        /// <returns></returns>
        public OrderQueryDiscountsInfoResponse QueryDiscountsInfo(OrderQueryDiscountsInfoRequest request)
        {
            OrderQueryDiscountsInfoResponse response = new OrderQueryDiscountsInfoResponse();
            return response;
        }
        /// <summary>
        /// 查询商品规格表[S  M  L  XL]
        /// </summary>
        /// <returns></returns>
        public OrderQueryCommodityTypeResponse QueryCommodityType(OrderQueryCommodityTypeRequest request)
        {
            OrderQueryCommodityTypeResponse response = new OrderQueryCommodityTypeResponse();
            return response;
        }
        /// <summary>
        /// 查询订单类型表[看快递走到哪了]
        /// </summary>
        /// <returns></returns>
        public OrderQueryOrderTypeResponse QueryOrderType(OrderQueryOrderTypeRequest request)
        {
            OrderQueryOrderTypeResponse response = new OrderQueryOrderTypeResponse();
            return response;
        }
        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public OrderAddResponse AddOrderInfo(OrderAddRequest request)
        {
            OrderAddResponse response = new OrderAddResponse();
            return response;
        }

        /// <summary>
        /// 逻辑删除订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderDeleteResponse DelOrderInfo(OrderDeleteRequest request)
        {
            OrderDeleteResponse response = new OrderDeleteResponse();
            return response;
        }

        /// <summary>
        /// 根据用户id获取单条信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderGetOneOrderInfoResponse GetOneOrderInfo(OrderGetOneOrderInfoRequest request)
        {
            OrderGetOneOrderInfoResponse response = new OrderGetOneOrderInfoResponse();
            return response;
        }

        /// <summary>
        /// 编辑方法
        /// </summary>
        /// <param name="info"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderUpdateResponse UpdateOrderInfo(OrderUpdateRequest request)
        {

            OrderUpdateResponse response = new OrderUpdateResponse();
            return response;
        }
    }
}
