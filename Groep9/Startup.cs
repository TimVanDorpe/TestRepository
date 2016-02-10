using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Groep9.Startup))]
namespace Groep9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
