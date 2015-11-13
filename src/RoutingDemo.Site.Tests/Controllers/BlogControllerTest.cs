using System;
using System.Web.Mvc;
using System.Web.Routing;
using MvcContrib.TestHelper;
using NUnit.Framework;
using RoutingDemo.Site.Controllers;

namespace RoutingDemo.Site.Tests.Controllers
{
    [TestFixture]
    public class BlogControllerTest
    {
        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            var routes = RouteTable.Routes;
            routes.Clear();
            routes.MapRoute(
                name: "CatchAll",
                url: "{controller}/{action}/{*id}",
                defaults: new { controller = "Travel", action = "Destinations", id = UrlParameter.Optional }
            );
            routes.MapRoute("blog", "{year}/{month}/{day}/{blogtitle}",
                                new { controller = "blog", action = "article" },
                               constraints: new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" });
            routes.MapRoute( "Default",    "{controller}",   new { controller = "Blog", action = "Index", id = "" } );
            
        }

        [Test]
        public void root_maps_to_home_index()
        {
            "~/blog".ShouldMapTo<BlogController>(x => x.Index());
        }

        [Test]
        public void root_maps_to_tudent_index()
        {
            "~/travel/story".ShouldMapTo<TravelController>(x => x.Story(String.Empty));
        }

        [Test]
        public void post_maps_to_blog_article()
        {
            "~/blog/2008/12/12/visual-studio-2015-razor-syntax".ShouldMapTo<BlogController>(x => x.Article("visual-studio-2015-razor-syntax"));
        }
    }
}
