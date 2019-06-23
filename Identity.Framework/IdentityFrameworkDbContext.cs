using Identity.Framework.Entities;
using Identity.Framework.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Identity.Framework
{
    public class IdentityFrameworkDbContext : IdentityDbContext
        <
             IdentityFrameworkUser,
             IdentityFrameworkRole,
             int,
             IdentityFrameworkUserClaim,
             IdentityFrameworkUserRole,
             IdentityFrameworkUserLogin,
             IdentityFrameworkRoleClaim,
             IdentityFrameworkUserToken
        >
    {
        public IdentityFrameworkDbContext()
        {

        }

        public IdentityFrameworkDbContext(DbContextOptions<IdentityFrameworkDbContext> options) : base(options)
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
