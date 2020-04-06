using ApiSDKClient.FApi.Request.Comt;
using ApiSDKClient.FApi.Response.Comt;
using Bll.Comt;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FApi.Controllers.Comt
{
    /// <summary>
    /// API接口
    /// </summary>
    [ApiAuthorize]
    public class CommodityController : ApiController
    {
        /// <summary>
        /// 添加颜色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommColorAddResponse AddColor(CommColorAddRequest request)
        {
            return CommodityBll.Instance.ColorAdd(request);
        }

        /// <summary>
        /// 显示颜色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommColorShowResponse ShowColor(CommColorShowRequest request)
        {
            return CommodityBll.Instance.ColorShow(request);
        }

        /// <summary>
        /// 编辑商品    颜色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommColorUptResponse UptColor(CommColorUptRequest request)
        {
            return CommodityBll.Instance.ColorUpt(request);
        }

        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommodityAddResponse CommosityAdd(CommodityAddRequest request)
        {
            return CommodityBll.Instance.CommodityAdd(request);
        }

        /// <summary>
        /// 显示商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommodityShowResponse CommodityShow(CommodityShowRequest request)
        {
            return CommodityBll.Instance.CommodityShow(request);
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommodityDelResponse CommodityDel(CommodityDelRequest request)
        {
            return CommodityBll.Instance.CommodityDel(request);
        }

        /// <summary>
        /// 查询商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommodityInquireResponse CommodityInquire(CommodityInquireRequest request)
        {
            return CommodityBll.Instance.InquireCommodity(request);
        }

        /// <summary>
        /// 修改上架状态
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommodityUptResponse CommodityUpt(CommodityUptRequest request)
        {
            return CommodityBll.Instance.CommodityUpt(request);
        }

        /// <summary>
        /// 获取用户单条信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommodityUptRes GetCommodityInfo(CommodityUptReq request)
        {
            return CommodityBll.Instance.GetOneCommodityInfo(request);
        }

        /// <summary>
        /// 编辑商品信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommodityUpdateRes UpdateCommodityInfo(CommodityUpdateReq request)
        {
            return CommodityBll.Instance.UpdateCommodityInfo(request);
        }


        /// <summary>
        /// 添加类别
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommTypeAddResponse CommTypeAdd(CommTypeAddRequest request)
        {

            return CommodityBll.Instance.TypeAdd(request);
        }

        /// <summary>
        /// 显示类别
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CommTypeShowResponse CommTypeShow(CommTypeShowRequest request)
        {
            return CommodityBll.Instance.TypeShow(request);
        }





    }
}
