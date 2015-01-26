using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Live_Demo_Web_Forms.Startup))]
namespace Live_Demo_Web_Forms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
