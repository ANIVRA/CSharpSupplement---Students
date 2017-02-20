using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharpSupplement.Startup))]
namespace CSharpSupplement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
