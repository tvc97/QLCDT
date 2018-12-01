using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QL_CDT.Startup))]
namespace QL_CDT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
