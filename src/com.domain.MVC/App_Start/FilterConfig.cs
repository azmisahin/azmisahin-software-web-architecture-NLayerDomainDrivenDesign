using System.Web;
using System.Web.Mvc;

namespace com.domain
{
    /// <summary>
    /// Filter Configuration
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Global Routing Filter
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
