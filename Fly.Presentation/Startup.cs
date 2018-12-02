using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fly.Presentation.Startup))]
namespace Fly.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
