using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(autenticacao.Startup))]
namespace autenticacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
