using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ePortafolio.Startup))]
namespace ePortafolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
