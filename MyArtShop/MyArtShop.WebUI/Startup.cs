using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyArtShop.WebUI.Startup))]
namespace MyArtShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
