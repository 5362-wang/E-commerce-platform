﻿using ApiSDKClient.FApi.Request.Comt;
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
        CommodityDal dal = new CommodityDal();

        /// <summary>
        /// 添加颜色
        /// </summary>
        /// <returns></returns>
        public CommColorAddResponse ColorAdd(CommColorAddRequest commodityColor)
        {
            CommColorAddResponse response = new CommColorAddResponse();
            return response;
        }
        /// <summary>
        /// 显示颜色
        /// </summary>
        /// <returns></returns>
        public CommColorShowResponse ColorShow(CommColorShowRequest commColor)
        {
            CommColorShowResponse response = new CommColorShowResponse();
            return response;
        }
        /// <summary>
        /// 修改颜色
        /// </summary>
        /// <returns></returns>
        public CommColorUptResponse ColorUpt(CommColorUptRequest color)
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
        public CommodityShowResponse CommodityShow()
        {
            CommodityShowResponse response = new CommodityShowResponse();
            return response;
        }
        /// <summary>                                                              
        /// 查询商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public CommodityInquireResponse InquireCommodity(CommodityInquireRequest info)
        {
            CommodityInquireResponse response = new CommodityInquireResponse();
            return response;
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommodityDelResponse CommodityDel(CommodityDelRequest info)
        {
            CommodityDelResponse response = new CommodityDelResponse();
            return response;
        }

        /// <summary>
        /// 编辑商品
        /// </summary>
        /// <returns></returns>
        public CommodityUptResponse CommodityUpt(CommodityUptRequest info)
        {
            CommodityUptResponse response = new CommodityUptResponse();
            return response;
        }

        /// <summary>
        /// 添加类别
        /// </summary>
        /// <returns></returns>
        public CommTypeAddResponse TypeAdd(CommTypeAddRequest commodityType)
        {
            CommTypeAddResponse response = new CommTypeAddResponse();
            return response;
        }

        /// <summary>
        /// 显示类别
        /// </summary>
        /// <returns></returns>
        public CommTypeShowResponse TypeShow()
        {
            CommTypeShowResponse response = new CommTypeShowResponse();
            return response;
        }
    }
}