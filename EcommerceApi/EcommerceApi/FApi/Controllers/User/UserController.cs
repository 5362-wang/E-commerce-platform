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
        /// 用户登录的接口
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public UserLoginResponse UserLogin(UserLoginRequest request)
        {
            return UserBll.Instance.UserLogin(request);
        }
        /// <summary>
        /// 修改密码的接口
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public UserFindResponse FindPwd(UserFindRequest request)
        {
            return UserBll.Instance.FindPwd(request);
        }
        /// <summary>
        /// 根据用户id 获取一条用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        public UserGetResponse GetUserInfo(UserGetRequest request)
        {
            return UserBll.Instance.GetUser(request);
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

        //查看用户详情
        [HttpPost]
        public UserGetResponse GetUser(UserGetRequest request)
        {
            return UserBll.Instance.GetUserInfo(request);
        }

    }
}
