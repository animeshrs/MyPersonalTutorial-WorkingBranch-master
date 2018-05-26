using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPersonalTutorial.Startup))]
namespace MyPersonalTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
