using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BloodAlcoholAssistant
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Welcome",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Assistant", action = "Welcome", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Details",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Assistant", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Result",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Assistant", action = "Result", id = UrlParameter.Optional }
            );
        }
    }
}
