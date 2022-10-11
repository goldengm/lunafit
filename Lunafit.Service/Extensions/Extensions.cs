using Lunafit.Service.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Lunafit.Service.Extensions
{
    public static class Extensions
    {
        public static void AddServices(this IServiceCollection services)
        {            
            services.AddTransient<IWebApiCall, WebApiCall>();
        }
    }
}
