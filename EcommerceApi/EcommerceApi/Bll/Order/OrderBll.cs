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
    public class OrderBll : BaseBll<OrderBll>
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

            response.QueryOrderInfo = dal.QueryOrderInfo(request.name, request.OrderTypeId);
            if (response.QueryOrderInfo.Count > 0)
            {
                response.Status = true;
                response.Message = "查询成功";
            }
            else
            {
                response.Status = false;
                response.Message = "查询失败";
            }
            return response;
        }
        /// <summary>
        /// 查询优惠信息表[9折  7折  5折  免单]
        /// </summary>
        /// <returns></returns>
        public OrderQueryDiscountsInfoResponse QueryDiscountsInfo(OrderQueryDiscountsInfoRequest request)
        {
            OrderQueryDiscountsInfoResponse response = new OrderQueryDiscountsInfoResponse();
            response.QueryDiscountsInfo = dal.QueryDiscountsInfo();
            if (response.QueryDiscountsInfo.Count > 0)
            {
                response.Status = true;
                response.Message = "查询成功";
            }
            else
            {
                response.Status = false;
                response.Message = "查询失败";
            }
            return response;
        }
        /// <summary>
        /// 查询商品规格表[S  M  L  XL]
        /// </summary>
        /// <returns></returns>
        public OrderQueryCommodityTypeResponse QueryCommodityType(OrderQueryCommodityTypeRequest request)
        {
            OrderQueryCommodityTypeResponse response = new OrderQueryCommodityTypeResponse();
            response.QueryCommodityType = dal.QueryCommodityType();
            if (response.QueryCommodityType.Count > 0)
            {
                response.Status = true;
                response.Message = "查询成功";
            }
            else
            {
                response.Status = false;
                response.Message = "查询失败";
            }
            return response;
        }
        /// <summary>
        /// 查询订单类型表[看快递走到哪了]
        /// </summary>
        /// <returns></returns>
        public OrderQueryOrderTypeResponse QueryOrderType(OrderQueryOrderTypeRequest request)
        {
            OrderQueryOrderTypeResponse response = new OrderQueryOrderTypeResponse();
            response.QueryOrderType = dal.QueryOrderType();
            if (response.QueryOrderType.Count > 0)
            {
                response.Status = true;
                response.Message = "查询成功";
            }
            else
            {
                response.Status = false;
                response.Message = "查询失败";
            }
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
            OrderInfo orderInfo = new OrderInfo()
            {
                BoughtTime = request.BoughtTime,
                OrderName = request.OrderName,
                CommodityImg = request.CommodityImg,
                OrderSize = request.OrderSize,
                OrderCount = request.OrderCount,
                YhId = request.YhId,
                OrderPrice = request.OrderPrice,
                OrderTypeId = request.OrderTypeId,
                Consignee = request.Consignee,
                ConsigneeTel = request.ConsigneeTel,
                Staus = request.Staus,
                CreateId = request.CreateId,
                UpdateId = request.UpdateId,
                CreateTime = request.CreateTime,
                UpdateTime = request.UpdateTime
            };
            var res = dal.AddOrderInfo(orderInfo);
            if (res > 0)
            {
                response.IsAddSuccess =1;
                response.Message = "添加成功";
            }
            else
            {
                response.IsAddSuccess = 0;
                response.Message = "注册失败";
            }
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
            OrderInfo info = new OrderInfo()
            {
                OrderId=request.OrderId,
            };
            var res = dal.DelOrderInfo(info.OrderId);
            if (res > 0)
            {
                response.Status = false;
                response.Message = "删除成功";
            }
            else
            {
                response.Status = true;
                response.Message = "删除失败";
            }
            return response;
        }

        /// <summary>
        /// 根据用户id获取单条信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public OrderGetOneOrderInfoResponse GetOneOrderInfo(OrderGetOneOrderInfoRequest request)
        //{
        //    OrderGetOneOrderInfoResponse response = new OrderGetOneOrderInfoResponse();
        //    return response;
        //}

        /// <summary>
        /// 编辑方法
        /// </summary>
        /// <param name="info"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderUpdateResponse UpdateOrderInfo(OrderUpdateRequest request)
        {

            OrderUpdateResponse response = new OrderUpdateResponse();
            OrderInfo orderInfo = new OrderInfo()
            {
                BoughtTime = request.BoughtTime,
                OrderName = request.OrderName,
                CommodityImg = request.CommodityImg,
                OrderSize = request.OrderSize,
                OrderCount = request.OrderCount,
                YhId = request.YhId,
                OrderPrice = request.OrderPrice,
                OrderTypeId = request.OrderTypeId,
                Consignee = request.Consignee,
                ConsigneeTel = request.ConsigneeTel,
                Staus = request.Staus,
                CreateId = request.CreateId,
                UpdateId = request.UpdateId,
                CreateTime = request.CreateTime,
                UpdateTime = request.UpdateTime
            };
            var res = dal.UpdateOrderInfo(orderInfo);
            if (res > 0)
            {
                response.IsUpdateSuccess = 1;
                response.Message = "添加成功";
            }
            else
            {
                response.IsUpdateSuccess = 0;
                response.Message = "注册失败";
            }
            return response;
        }
    }
}
