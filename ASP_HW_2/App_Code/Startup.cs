using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_HW_2.Startup))]
namespace ASP_HW_2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
