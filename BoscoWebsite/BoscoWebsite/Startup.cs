using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoscoWebsite.Startup))]
namespace BoscoWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
