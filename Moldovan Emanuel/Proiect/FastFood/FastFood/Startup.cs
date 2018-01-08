using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FastFood.Startup))]
namespace FastFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
