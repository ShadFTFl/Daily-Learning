using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMdApp.Startup))]
namespace WebMdApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
