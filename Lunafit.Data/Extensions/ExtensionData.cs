using Lunafit.Data.Repositories;
using Lunafit.Data.Repositories.IRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunafit.Data.Extensions
{
    public static class ExtensionData
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IToDoRepository), typeof(ToDoRepository));
        }

    }
}
