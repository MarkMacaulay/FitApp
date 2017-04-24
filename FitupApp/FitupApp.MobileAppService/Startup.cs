using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FitupApp.MobileAppService.Startup))]

namespace FitupApp.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}