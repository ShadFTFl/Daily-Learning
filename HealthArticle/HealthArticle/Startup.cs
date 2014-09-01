using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthArticle.Startup))]
namespace HealthArticle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
