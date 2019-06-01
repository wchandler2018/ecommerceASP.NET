using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myEcommerce.WebUI.Startup))]
namespace myEcommerce.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
