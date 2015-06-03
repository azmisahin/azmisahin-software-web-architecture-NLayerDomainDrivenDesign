using System.Web.Http;
using System.Web.Mvc;

namespace com.domain.Help.HelpPage
{
    public class HelpPageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Help";
            }
        }

        public override void RegisterArea(AreaRegistrationContext routes)
        {
            routes.MapRoute(
                name: "Help"
                , url: "Help/{action}/{apiId}"
                , defaults: new { controller = "Help", action = "Index", apiId = UrlParameter.Optional }
                , namespaces: new[] { "com.domain.Help.Controllers" }
                );
            
            HelpPageConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}