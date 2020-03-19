using ApiSDKClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
namespace FApi.Controllers.User
{
    /// <summary>
    /// 用户相关相关的接口
    /// </summary>
    [ApiAuthorize]
    public class UserController : ApiController
    {
        /// <summary>
        /// 添加用户的接口
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [HttpPost]
        public UserAddResponse AddUser(UserAddRequest request)
        {
            return UserBll.Instance.UserRegist(request);
        }

       
        /// <summary>
        /// 根据用户id 获取一条用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        public UserGetResponse GetUserInfo(UserGetRequest request)
        {
            return new UserGetResponse();
        }

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public UserDeleteResponse DeleteUserInfo(UserDeleteRequest request)
        {
            return new UserDeleteResponse();
        }

        //修改用户的  
    }
}
