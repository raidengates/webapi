namespace Unititi.Framework.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Unititi.Framework.Func;
  
    public static class ServiceCollectionExtension
    {

        public static IServiceCollection AddUnititiFramework(this IServiceCollection services, IConfiguration configuration)
        {
            // Service
            services.AddScoped<IFuncIdentity, FuncIdentity>();
            // Repository
            // Mappers

            return services;
        }
    }
}
