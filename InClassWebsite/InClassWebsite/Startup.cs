using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClassWebsite.Startup))]
namespace InClassWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
