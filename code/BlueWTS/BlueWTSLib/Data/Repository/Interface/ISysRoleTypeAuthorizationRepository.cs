using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueWTSLib.Data.Repository.Interface
{
    public interface ISysRoleTypeAuthorizationRepository
    {
        SysRoleTypeAuthorization FindByUserAndAction(User user, string controller, string action);

        SysRoleTypeAuthorization FindByUserAndCode(User user, string code);
    }
}
