using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguyenhuutri_lab34.Startup))]
namespace nguyenhuutri_lab34
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
