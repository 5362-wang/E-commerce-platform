using ApiSDKClient;
using Bll.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FApi.Controllers.Order
{
    [ApiAuthorize]
    public class OrderController : ApiController
    {
        
        /// <summary>
        /// 查询订单表（并且可根据订单类型【快递到哪了】和商品名称进行查询）
        /// </summary>
        /// <param name="name"></param>
        /// <param name="OrderTypeId"></param>
        /// <returns></returns>
        [HttpPost]
        public OrderGetResponse QueryOrderInfo(OrderGetRequest request)
        {
            return OrderBll.Instance.QueryOrderInfo(request);
        }
        /// <summary>
        /// 查询优惠信息表[9折  7折  5折  免单]
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public OrderQueryDiscountsInfoResponse QueryDiscountsInfo(OrderQueryDiscountsInfoRequest request)
        {
            return OrderBll.Instance.QueryDiscountsInfo(request);
        }
        /// <summary>
        /// 查询商品规格表[S  M  L  XL]
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public OrderQueryCommodityTypeResponse QueryCommodityType(OrderQueryCommodityTypeRequest request)
        {
            return OrderBll.Instance.QueryCommodityType(request);
        }
        /// <summary>
        /// 查询订单类型表[看快递走到哪了]
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public OrderQueryOrderTypeResponse QueryOrderType(OrderQueryOrderTypeRequest request)
        {
            return OrderBll.Instance.QueryOrderType(request);
        }
        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [HttpPost]
        public OrderAddResponse AddOrderInfo(OrderAddRequest request)
        {
            return OrderBll.Instance.AddOrderInfo(request);
        }

        /// <summary>
        /// 逻辑删除订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public OrderDeleteResponse DelOrderInfo(OrderDeleteRequest request)
        {
            return OrderBll.Instance.DelOrderInfo(request);
        }

        /// <summary>
        /// 根据用户id获取单条信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public OrderGetOneOrderInfoResponse GetOneOrderInfo(OrderGetOneOrderInfoRequest request)
        {
            return OrderBll.Instance.GetOneOrderInfo(request);
        }

        /// <summary>
        /// 编辑方法
        /// </summary>
        /// <param name="info"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public OrderUpdateResponse UpdateOrderInfo(OrderUpdateRequest request)
        {

            return OrderBll.Instance.UpdateOrderInfo(request);
        }
    }
}
