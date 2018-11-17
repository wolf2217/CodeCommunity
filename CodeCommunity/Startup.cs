using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeCommunity.Startup))]
namespace CodeCommunity
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
