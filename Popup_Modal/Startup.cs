using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Popup_Modal.Startup))]
namespace Popup_Modal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
