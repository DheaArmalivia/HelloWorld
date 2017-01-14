using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWorld_DHEA_ARMALIVIA_09_XIRPL6.Startup))]
namespace HelloWorld_DHEA_ARMALIVIA_09_XIRPL6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
