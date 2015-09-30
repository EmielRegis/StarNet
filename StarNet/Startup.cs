using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarNet.Startup))]
namespace StarNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
