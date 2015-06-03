using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace com.domain.MVC
{
    public class Configure
    {
        /// <summary>
        /// Register Bundless
        /// </summary>
        /// <param name="bundles"></param>
        public static void Register()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            EngineConfig.Register();
        }
    }
}
