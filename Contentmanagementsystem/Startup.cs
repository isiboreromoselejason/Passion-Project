using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contentmanagementsystem.Startup))]
namespace Contentmanagementsystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
