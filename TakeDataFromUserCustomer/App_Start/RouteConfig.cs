using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TakeDataFromUserCustomer
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",              //Route Name
                url: "{controller}/{action}/{id}",    //URL with parameter
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }   //Parameter  by default we use
            );
        }
    }
}
