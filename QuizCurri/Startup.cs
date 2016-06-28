using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizCurri.Startup))]
namespace QuizCurri
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
