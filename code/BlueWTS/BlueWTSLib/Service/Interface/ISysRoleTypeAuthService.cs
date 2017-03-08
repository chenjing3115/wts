using BlueWTSLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueWTSLib.Service.Interface
{
    public interface ISysRoleTypeAuthService
    {
        bool PermitAction(User user, string controller, string action);

        bool PermitView(User user, string code);
    }
}
