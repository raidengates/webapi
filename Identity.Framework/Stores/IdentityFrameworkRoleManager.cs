using Identity.Framework.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Identity.Framework.Stores
{
    public class IdentityFrameworkRoleManager : RoleManager<IdentityFrameworkRole>
    {
        public IdentityFrameworkRoleManager(IRoleStore<IdentityFrameworkRole> store, IEnumerable<IRoleValidator<IdentityFrameworkRole>> roleValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, ILogger<RoleManager<IdentityFrameworkRole>> logger, IHttpContextAccessor contextAccessor) : base(store, roleValidators, keyNormalizer, errors, logger, contextAccessor)
        {
        }
    }
}
