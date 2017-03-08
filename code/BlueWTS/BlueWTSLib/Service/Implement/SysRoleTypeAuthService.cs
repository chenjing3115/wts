using BlueWTSLib.Data;
using BlueWTSLib.Data.Repository.Implement;
using BlueWTSLib.Data.Repository.Interface;
using BlueWTSLib.Model.Enum;
using BlueWTSLib.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueWTSLib.Service.Implement
{
    public class SysRoleTypeAuthService : ServiceBase, ISysRoleTypeAuthService
    {
        public SysRoleTypeAuthService(string dbString) : base(dbString)
        {
        }
        public SysRoleTypeAuthService(string dbString, User user) : base(dbString, user)
        {
        }

        public bool PermitAction(User user, string controller, string action)
        {
            if (user.roleTypeEnum == RoleType.Admin)
            {
                return true;
            }
            else
            {
                ISysRoleTypeAuthorizationRepository rep = new SysRoleTypeAuthorizationRepository(this.Context);
                return rep.FindByUserAndAction(user, controller, action) != null;
            }
        }

        public bool PermitView(User user, string code)
        {
            if (user.roleTypeEnum == RoleType.Admin)
            {
                return true;
            }
            else
            {
                ISysRoleTypeAuthorizationRepository rep = new SysRoleTypeAuthorizationRepository(this.Context);
                return rep.FindByUserAndCode(user, code) != null;
            }
        }
    }
}
