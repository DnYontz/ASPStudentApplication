using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentAssignmentManager.Startup))]
namespace StudentAssignmentManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
