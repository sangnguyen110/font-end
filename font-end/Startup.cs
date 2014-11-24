using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(font_end.Startup))]
namespace font_end
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
