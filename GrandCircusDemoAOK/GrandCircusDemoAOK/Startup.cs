using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GrandCircusDemoAOK.Startup))]
namespace GrandCircusDemoAOK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
