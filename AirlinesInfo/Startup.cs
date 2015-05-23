using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AirlinesInfo.Startup))]
namespace AirlinesInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
