using BlueWTSLib.Data;
using BlueWTSLib.Model.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueWTSLib.Service.Interface
{
   public interface IUserService
    {
        User FindById(int id);
        List<User> All();

        User Auth(string loginField, string pwd);

    }
}
