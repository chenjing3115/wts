using BlueWTSLib.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueWTSLib.Data.Repository.Implement
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private BlueWTSDbDataContext context;
        public UserRepository(IDataContextFactory context) : base(context)
        {
            this.context = this._dataContextFactory.Context as BlueWTSDbDataContext;
        }

        public UserRepository(IDataContextFactory context, User user) : base(context, user)
        {
            this.context = this._dataContextFactory.Context as BlueWTSDbDataContext;
        }

        public bool Create(User user)
        {
            try
            {
                User us = FindById(user.id);
                this.context.User.InsertOnSubmit(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<User> GetAll()
        {
            var q = this.context.User;
            return q == null ? new List<User>() : q.ToList();
        }

        public User FindById(int id)
        {
            return this.context.User.FirstOrDefault(u => u.id==id);
        }
    }
}
