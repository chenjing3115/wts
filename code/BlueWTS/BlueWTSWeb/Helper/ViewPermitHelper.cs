using BlueWTSLib.Data;
using BlueWTSLib.Service.Implement;
using BlueWTSWeb.Properties;

namespace BlueWTSWeb.Helper
{
    public class ViewPermitHelper
    {
        public static bool Permit(string code)
        {
            User user = System.Web.HttpContext.Current.Session["user"] as User;
            if (user == null || !user.roleType.HasValue)
            {
                return false;
            }
            return new SysRoleTypeAuthService(Settings.Default.db)
                .PermitView(user, code);
        }
    }

}