using System.Web.Http;
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

            #region IgnoreRouteNotes
            /*
             Ignoring a route simple instructs the MVC framework  not to pick up 
             those URLS. This means that the underlying ASP.NET infrastructure will handle
             the request. So if the file exists on disk just like ignoreme.html, MVC ignores it
             but it is still picked up by the ASP.NET framework and is rendered in the browser.
             */
            #endregion


            routes.IgnoreRoute("{resource}.html");

            //Attribute Routing route registration
            routes.MapMvcAttributeRoutes();

            //Traditional routing route registration
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //Traditional routing route registration
            routes.MapRoute(
                name: "CatchAll",
                url: "{controller}/{action}/{*id}",
                defaults: new { controller = "Travel", action = "Destinations", id = UrlParameter.Optional }
            );

            routes.MapHttpRoute(
                name: "ApiDefaults",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });


            /*
                Route Constraints
            */
            routes.MapRoute("blog", "{year}/{month}/{day}/{blogtitle}",
                                new { controller = "blog", action = "index" },
                               constraints: new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" });


            //http://local.routing.com/blog/2008/12/12/visual-studio-2015-razor-syntax

            //Api 
           // http://local.routing.com/api/Students/2/grades


        }
    }
}
