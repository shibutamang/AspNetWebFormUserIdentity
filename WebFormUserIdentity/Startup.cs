using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormUserIdentity.Startup))]
namespace WebFormUserIdentity
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
