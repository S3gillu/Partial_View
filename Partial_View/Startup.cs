using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Partial_View.Startup))]
namespace Partial_View
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
