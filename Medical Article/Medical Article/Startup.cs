using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Medical_Article.Startup))]
namespace Medical_Article
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
