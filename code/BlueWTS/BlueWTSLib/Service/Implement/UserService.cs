using BlueWTSLib.Data;
using BlueWTSLib.Service.Interface;
using System;
using System.Linq;
using System.Collections.Generic;
using BlueWTSLib.Model.Message;
using BlueWTSLib.Data.Repository.Interface;
using BlueWTSLib.Data.Repository.Implement;
using BlueWTSLib.Helper;

namespace BlueWTSLib.Service.Implement
{
    public class UserService : ServiceBase, IUserService
    {

        private IUserRepository rep;
        public UserService(string dbString) : base(dbString) {
            rep = new UserRepository(this.Context, this.User);
        }
        public UserService(string dbString, User user) : base(dbString, user) {
            rep = new UserRepository(this.Context, this.User);
        }

        public List<User> All()
        {
            return rep.GetAll();
        }
        public User FindByLoginField(string loginField)
        {
            DataContext dc = new DataContext(this.DbString);
            return dc.Context.GetTable<User>().FirstOrDefault(s => s.nr == loginField || s.email == loginField || s.name == loginField);
        }

        public User Auth(string loginField, string pwd)
        {
            User u = FindByLoginField(loginField);

            if (u != null)
            {
                // 中都 系统
                if (u.pwd == MD5Helper.Encryt(string.Format("{0}{1}", pwd, u.pwdSalt)))
                {
                    return u;
                }
            }
            return null;
        }

        public User FindById(int id)
        {
            return rep.FindById(id);
        }
    }
}
