using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alela.Startup))]
namespace Alela
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
