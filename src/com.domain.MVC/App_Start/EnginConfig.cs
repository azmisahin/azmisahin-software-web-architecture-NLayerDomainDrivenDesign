using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace com.domain
{
    /// <summary>
    /// Engine
    /// </summary>
    public class EngineConfig
    {
        /// <summary>
        /// Register
        /// </summary>
        public static void Register()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new ManageEngine());
        }

        /// <summary>
        /// Admin Engine
        /// </summary>
        public class ManageEngine : RazorViewEngine
        {
            public ManageEngine()
            {
                AreaViewLocationFormats = new[]
                {
                    "~/themes/manage/views/{1}/{0}.cshtml",
                    "~/themes/manage/views/shared/{0}.cshtml"
                };

                AreaMasterLocationFormats = new[]
                {
                    "~/themes/manage/views/{1}/{0}.cshtml",
                    "~/themes/manage/views/shared/{0}.cshtml"
                };

                AreaPartialViewLocationFormats = new[]
                {
                    "~/themes/manage/views/{1}/{0}.cshtml",
                    "~/themes/manage/views/{0}.cshtml"
                };

                //
                ViewLocationFormats = new[]
                {
                    "~/themes/web/views/{1}/{0}.cshtml",
                    "~/themes/web/views/shared/{0}.cshtml"
                };

                MasterLocationFormats = new[]
                {
                    "~/themes/web/views/{1}/{0}.cshtml",
                    "~/themes/web/views/shared/{0}.cshtml"
                };
                PartialViewLocationFormats = new[]
                {
                    "~/themes/web/views/{1}/{0}.cshtml",
                    "~/themes/web/views/shared/{0}.cshtml"
                };
                FileExtensions = new string[] { "cshtml" };
            }
        }
    }
}