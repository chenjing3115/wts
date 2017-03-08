
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueWTSLib.Data.Repository.Interface
{
    public interface IUserRepository
    {
        bool Create(User user);
        User FindById(int id);
        List<User> GetAll();
    }
}
