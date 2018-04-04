using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoveItVenya.Web.Startup))]
namespace MoveItVenya.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
