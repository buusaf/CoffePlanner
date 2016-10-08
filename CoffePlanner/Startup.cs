using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoffePlanner.Startup))]
namespace CoffePlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
