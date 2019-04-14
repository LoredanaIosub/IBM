using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SummerScool.Startup))]
namespace SummerScool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
