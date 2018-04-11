using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Goit_WebApplication1.Startup))]
namespace Goit_WebApplication1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
            ///
        }
    }
}
