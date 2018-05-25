using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nhatngu
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "ViewTest",
               url: "Cate-Menu/{NameCate}-{id}",
               defaults: new { controller = "Test", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "Nhatngu.Controllers" }
           );
            routes.MapRoute(
               name: "Logout",
               url: "{controller}/{action}",
               defaults: new { controller = "Login", action = "Logout"},
               namespaces: new[] { "Nhatngu.Controllers" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Nhatngu.Controllers"}
            );
        }
    }
}
