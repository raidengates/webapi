using Identities.WebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Identities.WebAPI.Stores
{
    public class IdentitiesWebAPIRoleManager : RoleManager<IdentitiesWebAPIRole>
    {
        public IdentitiesWebAPIRoleManager(IRoleStore<IdentitiesWebAPIRole> store, IEnumerable<IRoleValidator<IdentitiesWebAPIRole>> roleValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, ILogger<RoleManager<IdentitiesWebAPIRole>> logger) :
            base(store, roleValidators, keyNormalizer, errors, logger)
        {
        }

        //public IdentitiesWebAPIRoleManager(IRoleStore<IdentitiesWebAPIRole> store, IEnumerable<IRoleValidator<IdentitiesWebAPIRole>> roleValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, ILogger<RoleManager<IdentitiesWebAPIRole>> logger, IHttpContextAccessor contextAccessor) :
        //    base (store, roleValidators, keyNormalizer, errors, logger, contextAccessor)
        //{
        //}
    }
}
