using BlueWTSLib.Model.Message;
using Brilliantech.Framwork.Utils.LogUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlueWTSWeb.Controllers.API
{
    public class UsersController : ApiController
    {
        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpPost]
        public ResultMessage Login(string email, string pwd)
        {
            LogUtil.Logger.Info(Request);

            ResultMessage msg = new ResultMessage();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pwd))
            {
                msg.Content = "账号和密码不可空";
            }
            else
            {
                //IUserService s = new UserService(Settings.Default.db);
                //User user = s.Auth(email, pwd);
                //if (user != null)
                //{
                //    msg.Success = true;
                //    msg.Content = "登陆成功";
                //}
                //else
                //{
                //    msg.Content = "账号或密码错误";
                //}

                msg.Success = true;
                msg.Content = "登陆成功";
            }
            return msg;
        }
    }
}