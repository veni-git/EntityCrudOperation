using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityCrudOperation.Startup))]
namespace EntityCrudOperation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
