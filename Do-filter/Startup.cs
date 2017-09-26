using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Do_filter.Startup))]
namespace Do_filter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
