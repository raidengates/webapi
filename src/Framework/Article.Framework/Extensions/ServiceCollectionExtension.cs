using Article.Framework.Data.Entities;
using Article.Framework.Services;
using Article.Framework.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Article.Framework.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddArticleFramework(this IServiceCollection services, IConfiguration configuration)
        {
            // Service
            services.AddScoped<ICategoryServices, CategoryServices>();
            services.AddDbContext<ArtDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServerConnection")));
            return services;
        }
    }
}
