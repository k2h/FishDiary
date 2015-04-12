using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FishDiary.Startup))]
namespace FishDiary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
