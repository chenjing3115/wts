using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartupAttribute(typeof(BlueWTSWeb.Startup))]
namespace BlueWTSWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 设置json，防止loop
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            // 取消默认权限
            //ConfigureAuth(app);
        }
    }
}
