using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OptionWebsite.Startup))]
namespace OptionWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
