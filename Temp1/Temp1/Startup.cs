using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Temp1.Startup))]
namespace Temp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
