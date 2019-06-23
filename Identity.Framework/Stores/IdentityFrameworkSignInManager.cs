using Identity.Framework.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
namespace Identity.Framework.Stores
{
    public class IdentityFrameworkSignInManager : SignInManager<IdentityFrameworkUser>
    {
        public IdentityFrameworkSignInManager(UserManager<IdentityFrameworkUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<IdentityFrameworkUser> claimsFactory, IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<IdentityFrameworkUser>> logger) : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger)
        {
        }
    }
}
