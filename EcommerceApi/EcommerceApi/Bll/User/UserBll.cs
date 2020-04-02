using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSDKClient;
using Dal.User;
using Common;
using Model;
namespace Bll
{
    public class UserBll:BaseBll<UserBll>
    {
        UserDal dal = new UserDal();
        public UserAddResponse UserRegist(UserAddRequest request )
        {
            UserAddResponse response = new UserAddResponse();
            if (string.IsNullOrEmpty(request.UserName))
            {
                response.Status = false;
                response.Message = "用户名不能为空";
                return response;
            }
            if (string.IsNullOrEmpty(request.Pwd))
            {
                response.Status = false;
                response.Message = "密码不能为空";
                return response;
            }
            //是否已经注册
           var isExist= dal.IsExistPhone(request.UserName);
            if (isExist)
            {
                response.Status = false;
                response.Message = "用户名已经存在";
                return response;
            }
            //对密码进行加密
            //1.先生成一个盐
            var salt = Generate.GenerateSalt();
            //2.加密
            var password = MD5Encrypt.MD5Encrypt32(request.Pwd);
            UserInfo userInfo = new UserInfo()
            {             
               
               UserName= request.UserName,
               Phone=request.Phone,
                PassWord = password,
                Salt = salt
            };
          var res= dal.UserRegist(userInfo);
            if (res>0)
            {
                response.RegistSuccess = true;
                response.Message = "注册成功";
            }
            else
            {
                response.RegistSuccess = false;
                response.Message = "注册失败";
            }
            return response;
        }
        public UserLoginResponse UserLogin(UserLoginRequest request)
        {
            UserLoginResponse userLoginResponse = new UserLoginResponse();
            if (string.IsNullOrEmpty(request.UserName))
            {
                userLoginResponse.Status = false;
                userLoginResponse.Message = "用户名不能为空";
                return userLoginResponse;
            }
            if (string.IsNullOrEmpty(request.PassWord))
            {
                userLoginResponse.Status = false;
                userLoginResponse.Message = "密码不能为空";
                return userLoginResponse;
            }
            var password = MD5Encrypt.MD5Encrypt32(request.PassWord);
            UserInfo userInfo = new UserInfo()
            { UserName = request.UserName,
                PassWord = password
            };
            userInfo = dal.UserLogin(userInfo.UserName,userInfo.PassWord);
            if (userInfo.Uid > 0)
            {              
                userLoginResponse.Uid = userInfo.Uid;
                userLoginResponse.UserImg = userInfo.UserImg;
                userLoginResponse.UserName = userInfo.UserName;
                userLoginResponse.DepartmentId = userInfo.DepartmentId;
                userLoginResponse.LoginSuccess = true;
                userLoginResponse.Message = "登录成功";
            }
            else
            {
                userLoginResponse.LoginSuccess = false;
                userLoginResponse.Message = "登录失败";
            }
            return userLoginResponse;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UserFindResponse FindPwd(UserFindRequest request)
        {
            UserFindResponse userFindResponse = new UserFindResponse();
            if (string.IsNullOrEmpty(request.Pwd))
            {
                userFindResponse.Status = false;
                userFindResponse.Message = "密码不能为空";
                return userFindResponse;
            }
            var password = MD5Encrypt.MD5Encrypt32(request.Pwd);
            var res = dal.FindPwd(request.UserName, password);
            if (res > 0)
            {
                userFindResponse.FindSuccess = true;
                userFindResponse.Message = "密码修改成功";
            }
            else
            {
                userFindResponse.FindSuccess = false;
                userFindResponse.Message = "密码修改失败";
            }
            return userFindResponse;
        }
        /// <summary>
        /// 用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UserGetResponse GetUser(UserGetRequest request)
        {
            UserGetResponse userGetResponse = new UserGetResponse();
            userGetResponse.UserInfoList = dal.GetUsers();
            if (userGetResponse.UserInfoList.Count()>0)
            {         
                userGetResponse.Message = "获取到用户信息";
            }
            else
            {
                userGetResponse.Message = "暂无用户信息";
            }
            return userGetResponse;
        }
        /// <summary>
        /// 查看用户详情
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UserGetResponse GetUserInfo(UserGetRequest request)
        {
            UserGetResponse userGetResponse = new UserGetResponse();
            userGetResponse.info = dal.GetInfo(request.Uid);
            if (userGetResponse.info.Uid > 0)
            {
                userGetResponse.Message = "获取到用户信息";
            }
            else
            {
                userGetResponse.Message = "暂无用户信息";
            }
            return userGetResponse;
        }
    }
}
