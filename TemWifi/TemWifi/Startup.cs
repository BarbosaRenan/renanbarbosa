using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemWifi.Startup))]
namespace TemWifi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
