using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Identities.WebAPI.Entities;
using Identities.WebAPI.Stores;
using Microsoft.AspNetCore.Identity;

namespace Identities.WebAPI.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddIdentityServer4Custom(this IServiceCollection services, string connectionString, string migrationAssembly)
        {
            services.AddIdentityServer()
                           .AddConfigurationStore(builder =>
                               builder.UseSqlServer(connectionString,
                               options => options.MigrationsAssembly(migrationAssembly)))
                                .AddOperationalStore(builder =>
                                      builder.UseSqlServer(connectionString, options =>
                                      options.MigrationsAssembly(migrationAssembly)))
                     .AddAspNetIdentity<IdentitiesWebAPIUser>()
                     .AddTemporarySigningCredential();

        }
        public static void AddEntityFrameWorkIdentityCustom(this IServiceCollection services)
        {
            services.AddIdentity<IdentitiesWebAPIUser, IdentitiesWebAPIRole>(identityOptions =>
            { }).AddUserStore<IdentitiesWebAPIUserStore>()
            .AddUserManager<IdentitiesWebAPIUserManager>()
            .AddRoleStore<IdentitiesWebAPIRoleStore>()
            .AddRoleManager<IdentitiesWebAPIRoleManager>()
            .AddSignInManager<IdentitiesWebAPISignInManager>();
        }
    }
}
