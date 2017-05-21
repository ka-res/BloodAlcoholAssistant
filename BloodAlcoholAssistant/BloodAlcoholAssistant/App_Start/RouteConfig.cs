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
                url: "{controller}/{action}",
                defaults: new { controller = "Assistant", action = "Welcome" }
            );

            routes.MapRoute(
                name: "Details",
                url: "{controller}/{action}",
                defaults: new { controller = "Assistant", action = "Details" }
            );

            routes.MapRoute(
                name: "Result",
                url: "{controller}/{action}",
                defaults: new { controller = "Assistant", action = "Result" }
            );
        }
    }
}
