using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tarea1._2.Startup))]
namespace Tarea1._2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
