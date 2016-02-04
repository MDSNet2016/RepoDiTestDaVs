using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myWebApp.Startup))]
namespace myWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
