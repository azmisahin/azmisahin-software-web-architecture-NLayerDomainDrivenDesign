using System.Web.Mvc;

namespace com.domain.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext routes) 
        {
            routes.MapRoute(
                name: "Admin_Default"
                , url: "Manage/{controller}/{action}/{id}"
                , defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                , namespaces: new[] { "com.domain.Admin.Controllers" }
                );
        }
    }
}