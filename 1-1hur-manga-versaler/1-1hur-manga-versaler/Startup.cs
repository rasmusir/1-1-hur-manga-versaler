using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1_1hur_manga_versaler.Startup))]
namespace _1_1hur_manga_versaler
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
