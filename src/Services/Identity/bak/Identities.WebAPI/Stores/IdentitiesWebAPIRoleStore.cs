using Identities.WebAPI.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;

namespace Identities.WebAPI.Stores
{
    public class IdentitiesWebAPIRoleStore : RoleStore<IdentitiesWebAPIRole, IdentitiesWebAPIDbContext, int, IdentitiesWebAPIUserRole, IdentitiesWebAPIRoleClaim>
    {
        public IdentitiesWebAPIRoleStore(IdentitiesWebAPIDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }


        //public IdentitiesWebAPIRoleStore(IdentitiesWebAPIDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        //{
        //}

        //protected override IdentitiesWebAPIRoleClaim CreateRoleClaim(IdentitiesWebAPIRole role, Claim claim)
        //{
        //    return new IdentitiesWebAPIRoleClaim { RoleId = role.Id, ClaimType = claim.Type, ClaimValue = claim.Value };
        //}
        protected override IdentitiesWebAPIRoleClaim CreateRoleClaim(IdentitiesWebAPIRole role, Claim claim)
        {
            throw new System.NotImplementedException();
        }
    }
}
