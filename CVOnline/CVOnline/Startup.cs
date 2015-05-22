using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVOnline.Startup))]
namespace CVOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
