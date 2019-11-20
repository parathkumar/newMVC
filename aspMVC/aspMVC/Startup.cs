using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspMVC.Startup))]
namespace aspMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
