using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcCarWebsite.Startup))]
namespace mvcCarWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
