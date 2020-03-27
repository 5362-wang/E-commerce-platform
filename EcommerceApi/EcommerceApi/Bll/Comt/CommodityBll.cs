using ApiSDKClient.FApi.Request.Comt;
using ApiSDKClient.FApi.Response.Comt;
using Dal.Comt;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Comt
{
    public class CommodityBll : BaseBll<CommodityBll>
    {
        /// <summary>
        /// 添加颜色
        /// </summary>
        /// <returns></returns>
        public CommColorAddResponse ColorAdd(CommColorAddRequest request)
        {
            CommColorAddResponse response = new CommColorAddResponse();
            return response;
        }
        /// <summary>
        /// 显示颜色
        /// </summary>
        /// <returns></returns>
        public CommColorShowResponse ColorShow(CommColorShowRequest request)
        {
            CommColorShowResponse response = new CommColorShowResponse();
            return response;
        }
        /// <summary>
        /// 修改颜色
        /// </summary>
        /// <returns></returns>
        public CommColorUptResponse ColorUpt(CommColorUptRequest request)
        {
            CommColorUptResponse response = new CommColorUptResponse();
            return response;
        }


        /// <summary>
        /// 添加商品
        /// </summary>
        /// <returns></returns>
        public CommodityAddResponse CommodityAdd(CommodityAddRequest request)
        {
            CommodityAddResponse response = new CommodityAddResponse();
            return response;
        }
        /// <summary>                                                              
        /// 显示商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public CommodityShowResponse CommodityShow(CommodityShowRequest request)
        {
            CommodityShowResponse response = new CommodityShowResponse();
            return response;
        }
        /// <summary>                                                              
        /// 查询商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public CommodityInquireResponse InquireCommodity(CommodityInquireRequest request)
        {
            CommodityInquireResponse response = new CommodityInquireResponse();
            return response;
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommodityDelResponse CommodityDel(CommodityDelRequest request)
        {
            CommodityDelResponse response = new CommodityDelResponse();
            return response;
        }

        /// <summary>
        /// 编辑商品
        /// </summary>
        /// <returns></returns>
        public CommodityUptResponse CommodityUpt(CommodityUptRequest request)
        {
            CommodityUptResponse response = new CommodityUptResponse();
            return response;
        }

        /// <summary>
        /// 添加类别
        /// </summary>
        /// <returns></returns>
        public CommTypeAddResponse TypeAdd(CommTypeAddRequest request)
        {
            CommTypeAddResponse response = new CommTypeAddResponse();
            return response;
        }

        /// <summary>
        /// 显示类别
        /// </summary>
        /// <returns></returns>
        public CommTypeShowResponse TypeShow( CommTypeShowRequest request)
        {
            CommTypeShowResponse response = new CommTypeShowResponse();
            return response;
        }
    }
}
