using Microsoft.Extensions.DependencyInjection;
using Services.Services.CustomerServices;
using Services.Services.PersonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddProjectCoreServices(this IServiceCollection services)
        {
            return services
                .AddProjectPersonServices()
                .AddProjectCustomerServices();
        }

        public static IServiceCollection AddProjectPersonServices(this IServiceCollection services)
        {
            return services.AddScoped<IPersonService, PersonService>();
        }

        public static IServiceCollection AddProjectCustomerServices(this IServiceCollection services)
        {
            return services.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
