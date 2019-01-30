using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NutritionEvaluationSystem.WebClient.Startup))]
namespace NutritionEvaluationSystem.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
