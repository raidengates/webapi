using Identity.Framework.Entities;
using Identity.Framework.Stores;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Identity.Framework.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddIdentityServer4Custom(this IServiceCollection services, string connectionString, string migrationAssembly)
        {

            //When using dotnet ef migrations an assembly is neccesary.
            services.AddIdentityServer()
                           .AddConfigurationStore(builder =>
                               builder.UseSqlServer(connectionString,
                               options => options.MigrationsAssembly(migrationAssembly)))
                                .AddOperationalStore(builder =>
                                      builder.UseSqlServer(connectionString, options =>
                                      options.MigrationsAssembly(migrationAssembly)))
                     .AddAspNetIdentity<IdentityFrameworkUser>()
                     .AddTemporarySigningCredential();

        }
        public static void AddEntityFrameWorkIdentityCustom(this IServiceCollection services)
        {
            services.AddIdentity<IdentityFrameworkUser, IdentityFrameworkRole>(identityOptions =>
            {

            }).AddUserStore<IdentityFrameworkUserStore>()
            .AddUserManager<IdentityFrameworkUserManager>()
            .AddRoleStore<IdentityFrameworkRoleStore>()
            .AddRoleManager<IdentityFrameworkRoleManager>()
            .AddSignInManager<IdentityFrameworkSignInManager>()
            ;
        }
    }
}
