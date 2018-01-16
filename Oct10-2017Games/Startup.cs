using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oct10_2017Games.Startup))]
namespace Oct10_2017Games
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
