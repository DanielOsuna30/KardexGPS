using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KardexGPS.Startup))]
namespace KardexGPS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
