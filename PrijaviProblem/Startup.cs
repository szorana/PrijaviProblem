using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrijaviProblem.Startup))]
namespace PrijaviProblem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
