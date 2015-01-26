using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Live_DEmo_MVC.Startup))]
namespace Live_DEmo_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
