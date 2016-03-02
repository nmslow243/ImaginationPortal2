using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Imagination_Portal_2._0.Startup))]
namespace Imagination_Portal_2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
