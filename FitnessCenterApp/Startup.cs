using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitnessCenterApp.Startup))]
namespace FitnessCenterApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
