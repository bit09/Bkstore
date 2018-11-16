using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bkstore.Startup))]
namespace Bkstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
