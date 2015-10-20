using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoutingDemo.Site.Startup))]
namespace RoutingDemo.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
