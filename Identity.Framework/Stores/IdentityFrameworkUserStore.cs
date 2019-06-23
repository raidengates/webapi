using Identity.Framework.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;
namespace Identity.Framework.Stores
{
    public class IdentityFrameworkUserStore : UserStore<IdentityFrameworkUser,
          IdentityFrameworkRole,
          IdentityFrameworkDbContext,
          int,
          IdentityFrameworkUserClaim,
          IdentityFrameworkUserRole,
          IdentityFrameworkUserLogin,
          IdentityFrameworkUserToken,
          IdentityFrameworkRoleClaim>
    {
        public IdentityFrameworkUserStore(IdentityFrameworkDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }

        protected override IdentityFrameworkUserClaim CreateUserClaim(IdentityFrameworkUser user, Claim claim)
        {
            var userClaim = new IdentityFrameworkUserClaim { UserId = user.Id };
            userClaim.InitializeFromClaim(claim);
            return userClaim;
        }
        protected override IdentityFrameworkUserLogin CreateUserLogin(IdentityFrameworkUser user, UserLoginInfo login)
        {
            return new IdentityFrameworkUserLogin
            {
                UserId = user.Id,
                ProviderKey = login.ProviderKey,
                LoginProvider = login.LoginProvider,
                ProviderDisplayName = login.ProviderDisplayName
            };
        }

        protected override IdentityFrameworkUserRole CreateUserRole(IdentityFrameworkUser user, IdentityFrameworkRole role)
        {
            return new IdentityFrameworkUserRole()
            {
                UserId = user.Id,
                RoleId = role.Id
            };
        }
        protected override IdentityFrameworkUserToken CreateUserToken(IdentityFrameworkUser user, string loginProvider, string name, string value)
        {
            return new IdentityFrameworkUserToken
            {
                UserId = user.Id,
                LoginProvider = loginProvider,
                Name = name,
                Value = value
            };
        }

    }
}
