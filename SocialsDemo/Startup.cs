using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialsDemo.Startup))]
namespace SocialsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
