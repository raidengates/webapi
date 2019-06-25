using Identities.WebAPI.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Identities.WebAPI.Stores
{
    public class IdentitiesWebAPISignInManager : SignInManager<IdentitiesWebAPIUser>
    {

        public IdentitiesWebAPISignInManager(UserManager<IdentitiesWebAPIUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<IdentitiesWebAPIUser> claimsFactory, IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<IdentitiesWebAPIUser>> logger, IAuthenticationSchemeProvider schemes, IUserConfirmation<IdentitiesWebAPIUser> confirmation) :
            base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation)
        {
        }
    }
}
