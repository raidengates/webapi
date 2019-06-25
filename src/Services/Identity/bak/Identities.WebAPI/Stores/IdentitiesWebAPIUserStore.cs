using Identities.WebAPI;
using Identities.WebAPI.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;

namespace Identities.WebAPI.Stores
{
    public class IdentitiesWebAPIUserStore : UserStore<IdentitiesWebAPIUser,
          IdentitiesWebAPIRole,
          IdentitiesWebAPIDbContext,
          int,
         IdentitiesWebAPIUserClaim,
         IdentitiesWebAPIUserRole,
          IdentitiesWebAPIUserLogin,
          IdentitiesWebAPIUserToken,
          IdentitiesWebAPIRoleClaim>
    {
        public IdentitiesWebAPIUserStore(IdentitiesWebAPIDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }

        protected override IdentitiesWebAPIUserClaim CreateUserClaim(IdentitiesWebAPIUser user, Claim claim)
        {
            var userClaim = new IdentitiesWebAPIUserClaim { UserId = user.Id };
            userClaim.InitializeFromClaim(claim);
            return userClaim;
        }
        protected override IdentitiesWebAPIUserLogin CreateUserLogin(IdentitiesWebAPIUser user, UserLoginInfo login)
        {
            return new IdentitiesWebAPIUserLogin
            {
                UserId = user.Id,
                ProviderKey = login.ProviderKey,
                LoginProvider = login.LoginProvider,
                ProviderDisplayName = login.ProviderDisplayName
            };
        }

      

        protected override IdentitiesWebAPIUserRole CreateUserRole(IdentitiesWebAPIUser user, IdentitiesWebAPIRole role)
        {
            return new IdentitiesWebAPIUserRole()
            {
                UserId = user.Id,
                RoleId = role.Id
            };
        }
        protected override IdentitiesWebAPIUserToken CreateUserToken(IdentitiesWebAPIUser user, string loginProvider, string name, string value)
        {
            return new IdentitiesWebAPIUserToken
            {
                UserId = user.Id,
                LoginProvider = loginProvider,
                Name = name,
                Value = value
            };
        }

    }
}
