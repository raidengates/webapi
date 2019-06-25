using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Identities.WebAPI.Entities
{
    public class IdentitiesWebAPIUser : IdentityUser<int, IdentitiesWebAPIUserClaim, IdentitiesWebAPIUserRole, IdentitiesWebAPIUserLogin>
    {
       
    }
}
