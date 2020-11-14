using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jobs_Offers_Website.Startup))]
namespace Jobs_Offers_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
