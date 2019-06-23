using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Identity.Framework.Entities
{
    public class IdentityFrameworkRole : IdentityRole<int, IdentityFrameworkUserRole, IdentityFrameworkRoleClaim>
    {
    }
}
