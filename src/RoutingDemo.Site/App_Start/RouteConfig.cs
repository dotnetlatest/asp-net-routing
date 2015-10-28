using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingDemo.Site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Ignore route
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Attribute Routing route registration
            routes.MapMvcAttributeRoutes();

            //Traditional routing route registration
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "RouteDefaults",
                url: "{controller}/{action}/{id}/",
                defaults: new { controller = "Home", action = "Index" }
                );

            routes.MapRoute(
                name:"blog",
                url: "{year}/{month}/{day}",
                defaults: new { controller = "blog", action = "index" },
                    new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" }
                    );
        }
    }
}
