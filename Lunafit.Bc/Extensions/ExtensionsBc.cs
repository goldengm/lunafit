using Lunafit.Bc.Interface;
using Lunafit.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
namespace Lunafit.Bc.Extensions
{
    public static class ExtensionsBc
    {
        public static void AddBcServices(this IServiceCollection services)
        {
            services.AddTransient<IToDoBc, ToDoBc>();
        }
    }
}
