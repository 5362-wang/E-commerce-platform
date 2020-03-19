using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common;

namespace FApi.Controllers
{
    /// <summary>
    /// 这个接口 就是为生成token用的
    /// 这里不做jwt验证，做用户和密码验证
    /// </summary>
    public class TokenController : ApiController
    {
        /// <summary>
        /// 获取权限验证token值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public string GetAuthToken(string name, string pwd)
        {
            var token = "";
            if (name == "王玺凯" && pwd == "123")  //登录这块 写到数据库中
            {
                IJwtAlgorithm algorithm = new HMACSHA256Algorithm();//HMACSHA256加密
                IJsonSerializer serializer = new JsonNetSerializer();//序列化和反序列
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();//Base64编解码
                IDateTimeProvider provider = new UtcDateTimeProvider();//UTC时间获取 
                //iss：发行人  //exp：到期时间   //sub：主题   //aud：用户  
                //nbf：在此之前不可用   //iat：发布时间  //jti：JWT ID用于标识该JWT 
                Dictionary<string, object> payload = new Dictionary<string, object>();
                payload.Add("iss", "1707A");
                payload.Add("exp", DateTime.Now.AddYears(1).ToUnixTime());//时间戳
                payload.Add("sub", "jwt");
                payload.Add("aud", "1");
                payload.Add("nbf", DateTime.Now.ToUnixTime());
                payload.Add("iat", DateTime.Now.ToUnixTime());
                payload.Add("jti", "1");
                const string secret = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4aKpVo2OHXPwb1R7duLgg";//服务端
                IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
                token = encoder.Encode(payload, secret);
            }
            return token;
        }

    }
}
