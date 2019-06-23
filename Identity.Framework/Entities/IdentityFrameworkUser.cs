using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Identity.Framework.Entities
{
    public class IdentityFrameworkUser : IdentityUser<int, IdentityFrameworkUserClaim, IdentityFrameworkUserRole, IdentityFrameworkUserLogin>
    {
    }
}
