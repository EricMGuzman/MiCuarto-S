using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiCuarto_S.Startup))]
namespace MiCuarto_S
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
