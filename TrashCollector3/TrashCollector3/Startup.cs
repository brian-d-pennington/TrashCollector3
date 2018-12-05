using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashCollector3.Startup))]
namespace TrashCollector3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
