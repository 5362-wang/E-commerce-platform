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
            var password = MD5Encrypt.MD5Encrypt32(request.Pwd + salt);
            UserInfo userInfo = new UserInfo()
            {
                UserName = request.UserName,
                PhoneNumder = request.UserName,
                NickName = Extension.ToNickName(request.UserName),
                UserPass = password,
                Salt = salt
            };
          var res= dal.UserRegist(userInfo);
            if (res>0)
            {
                response.RegistSuccess = true;
            }
            else
            {
                response.RegistSuccess = false;
                response.Message = "注册失败";
            }
            return response;
        }
    }
}
