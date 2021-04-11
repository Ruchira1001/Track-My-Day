using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Act.Startup))]
namespace Act
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
