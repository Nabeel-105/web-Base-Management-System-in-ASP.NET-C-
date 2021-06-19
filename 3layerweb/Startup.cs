using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3layerweb.Startup))]
namespace _3layerweb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
