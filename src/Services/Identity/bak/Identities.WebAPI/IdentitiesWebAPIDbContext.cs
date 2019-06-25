using Identities.WebAPI.Entities;
using Identities.WebAPI.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Identities.WebAPI
{
    public class IdentitiesWebAPIDbContext : IdentityDbContext<
             IdentitiesWebAPIUser,
             IdentitiesWebAPIRole,
             int,
             IdentitiesWebAPIUserClaim,
             IdentitiesWebAPIUserRole,
             IdentitiesWebAPIUserLogin,
             IdentitiesWebAPIRoleClaim,
             IdentitiesWebAPIUserToken>
    {
        public IdentitiesWebAPIDbContext()
        {

        }

        public IdentitiesWebAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.AspNetIdentityTableConfig();
            builder.RemovePluralizingTableNameConvention();
        }


    }
}
