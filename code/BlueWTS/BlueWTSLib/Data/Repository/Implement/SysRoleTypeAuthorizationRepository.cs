using BlueWTSLib.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueWTSLib.Data.Repository.Implement
{
    class SysRoleTypeAuthorizationRepository : RepositoryBase<SysRoleTypeAuthorization>, ISysRoleTypeAuthorizationRepository
    {
        private BlueWTSDbDataContext context;

        public SysRoleTypeAuthorizationRepository(IDataContextFactory dataContextFactory) : base(dataContextFactory)
        {
            this.context = dataContextFactory.Context as BlueWTSDbDataContext;
        }

        public SysRoleTypeAuthorizationRepository(IDataContextFactory dataContextFactory, User user) : base(dataContextFactory, user)
        {
            this.context = dataContextFactory.Context as BlueWTSDbDataContext;
        }

        public SysRoleTypeAuthorization FindByUserAndAction(User user, string controller, string action)
        {
            var q = from sra in this.context.GetTable<SysRoleTypeAuthorization>()
                    join
                    sa in this.context.GetTable<SysAuthorization>()
                    on sra.sysAuthorizationId equals sa.id
                    select new
                    {
                        SysAuthorization = sa,
                        SysRoleTypeAuthorization = sra
                    }
                   into ssra
                    where ssra.SysRoleTypeAuthorization.roleType == user.roleType
                    && ssra.SysAuthorization.action == action && ssra.SysAuthorization.controller == controller
                    select ssra.SysRoleTypeAuthorization;


            return q.FirstOrDefault();
        }

        public SysRoleTypeAuthorization FindByUserAndCode(User user, string code)
        {

            var q = from sra in this.context.GetTable<SysRoleTypeAuthorization>()
                    join
                    sa in this.context.GetTable<SysAuthorization>()
                    on sra.sysAuthorizationId equals sa.id
                    select new
                    {
                        SysAuthorization = sa,
                        SysRoleTypeAuthorization = sra
                    }
                   into ssra
                    where ssra.SysRoleTypeAuthorization.roleType == user.roleType
                    && ssra.SysAuthorization.code == code
                    select ssra.SysRoleTypeAuthorization;

            return q.FirstOrDefault();
        }

    }
}
