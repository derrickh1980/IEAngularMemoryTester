using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemoryTester.Startup))]
namespace MemoryTester
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
