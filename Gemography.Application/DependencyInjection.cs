using System.Reflection;
using AspNetCore.ServiceRegistration.Dynamic;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gemography.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddServicesOfType<IScopedService>();
            services.AddServicesOfType<ISingletonService>();
            services.AddServicesOfType<ITransientService>();
            return services;
        }
    }
}
