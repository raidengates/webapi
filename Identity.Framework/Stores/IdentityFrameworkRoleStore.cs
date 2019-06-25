

using Identity.Framework.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;

namespace Identity.Framework.Stores
{
    public class IdentityFrameworkRoleStore : RoleStore<IdentityFrameworkRole, IdentityFrameworkDbContext, int, IdentityFrameworkUserRole, IdentityFrameworkRoleClaim>
    {
        public IdentityFrameworkRoleStore(IdentityFrameworkDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }

        protected override IdentityFrameworkRoleClaim CreateRoleClaim(IdentityFrameworkRole role, Claim claim)
        {
            return new IdentityFrameworkRoleClaim { RoleId = role.Id, ClaimType = claim.Type, ClaimValue = claim.Value };
        }

    }
}
