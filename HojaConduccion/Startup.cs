using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HojaConduccion.Startup))]
namespace HojaConduccion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
