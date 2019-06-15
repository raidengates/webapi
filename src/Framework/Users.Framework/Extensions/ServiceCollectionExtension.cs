using Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Users.Framework.Services;
using Users.Framework.Services.Interface;

namespace Users.Framework.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddUsersFramework(this IServiceCollection services, IConfiguration configuration)
        {
            // Service
            services.AddScoped<IUserServices, UserServices>();
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServerConnection")));
            return services;
        }
    }
}
