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

        CommodityDal dal = new CommodityDal();


        /// <summary>
        /// 添加颜色
        /// </summary>
        /// <returns></returns>
        public CommColorAddResponse ColorAdd(CommColorAddRequest request)
        {
            CommColorAddResponse response = new CommColorAddResponse();
            var res = dal.ColorAdd(request.Color);
            if (res > 0)
            {
                response.ColorSuccess = true;
            }
            else
            {
                response.ColorSuccess = false;
            }
            return response;
        }
        /// <summary>
        /// 显示颜色
        /// </summary>
        /// <returns></returns>
        public CommColorShowResponse ColorShow(CommColorShowRequest request)
        {
            CommColorShowResponse response = new CommColorShowResponse();
            List<CommodityColor> list = new List<CommodityColor>();
            list = dal.ColorShow();
            if (list.Count > 0)
            {
                response.ColorInfo = list;
            }
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
            CommodityInfo info = new CommodityInfo()
            {
                CommodName = request.CommodName,
                SystematicId = request.SystematicId,
                CommodityImg = request.CommodityImg,
                CommodityPrice = request.CommodityPrice,
                CommodityDetalis = request.CommodityDetalis,
                RegisterDate = request.RegisterDate,
                PutNumber = request.PutNumber,
                CountNumber = request.CountNumber,
            };
            var res = dal.CommodityAdd(info);
            if (res > 0)
            {
                response.CommoditySuccess = true;
            }
            else
            {
                response.CommoditySuccess = false;
            }
            return response;
        }
        /// <summary>                                                              
        /// 显示商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public CommodityShowResponse CommodityShow(CommodityShowRequest request)
        {
            CommodityShowResponse response = new CommodityShowResponse();
            response.CommodityInfoSuccess = dal.CommodityShow(request.name, request.CtypeId);
            if (response.CommodityInfoSuccess.Count() > 0)
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
        /// 查询商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public CommodityInquireResponse InquireCommodity(CommodityInquireRequest request)
        {
            CommodityInquireResponse response = new CommodityInquireResponse();
            // response.CommodityInquireSuccess = dal.InquireCommodity(request.CommodName);
            response.CommodityInquireSuccess = true;

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
            var res = dal.CommodityDel(request.id);
            if (res > 0)
            {
                response.CommodityDelSuccess = true;
            }
            else
            {
                response.CommodityDelSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 修改上架状态
        /// </summary>
        /// <returns></returns>
        public CommodityUptResponse CommodityUpt(CommodityUptRequest request)
        {
            CommodityUptResponse response = new CommodityUptResponse();
            CommodityInfo info = new CommodityInfo()
            {
                CommodityId = request.Id,
            };
            var res = dal.CommodityUpt(info.CommodityId);
            if (res > 0)
            {
                response.Status = true;
                response.Message = "上架";
            }
            else
            {
                response.Status = false;
                response.Message = "下架";
            }
            return response;
        }

        /// <summary>
        /// 获取单条信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CommodityUptRes GetOneCommodityInfo(CommodityUptReq request)
        {
            CommodityUptRes response = new CommodityUptRes();
            response.CommUpt = dal.GetOneCommodityInfo(request.Id);
            if (response.CommUpt != null)
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
        /// 编辑商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CommodityUpdateRes UpdateCommodityInfo(CommodityUpdateReq request)
        {
            CommodityUpdateRes response = new CommodityUpdateRes();
            CommodityInfo info = new CommodityInfo()
            {
                CommodName = request.CommodName,
                SystematicId = request.SystematicId,
                CommodityImg = request.CommodityImg,
                CommodityPrice = request.CommodityPrice,
                CommodityDetalis = request.CommodityDetalis,
                RegisterDate = request.RegisterDate,
                PutNumber = request.PutNumber,
                CountNumber = request.CountNumber,
            };
            var res = dal.UpdateCommodityInfo(info);
            if (res > 0)
            {
                response.CommodityUpdate = true;
                response.Message = "添加成功";
            }
            else
            {
                response.CommodityUpdate = false;
                response.Message = "注册失败";
            }
            return response;
        }


        /// <summary>
        /// 添加类别
        /// </summary>
        /// <returns></returns>
        public CommTypeAddResponse TypeAdd(CommTypeAddRequest request)
        {
            CommTypeAddResponse response = new CommTypeAddResponse();
            var res = dal.TypeAdd(request.TypeName);
            if (res > 0)
            {
                response.CommTypeSuccess = true;
            }
            else
            {
                response.CommTypeSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 显示类别
        /// </summary>
        /// <returns></returns>
        public CommTypeShowResponse TypeShow(CommTypeShowRequest request)
        {
            CommTypeShowResponse response = new CommTypeShowResponse();
            List<CommodityType> list = new List<CommodityType>();
            list = dal.TypeShow();
            if (list.Count > 0)
            {
                response.CommodityTypesSuccess = list;
            }

            return response;
        }
    }
}
