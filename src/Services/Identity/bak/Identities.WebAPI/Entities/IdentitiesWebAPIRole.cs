using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Identities.WebAPI.Entities
{
    public class IdentitiesWebAPIRole : IdentityRole<int, IdentitiesWebAPIUserRole, IdentitiesWebAPIRoleClaim>
    {
    }
}
