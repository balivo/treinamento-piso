using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestaoComercial.Web.Startup))]
namespace GestaoComercial.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
