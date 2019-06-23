using Identity.Framework.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Identity.Framework.Stores
{
    public class IdentityFrameworkUserManager : UserManager<IdentityFrameworkUser>
    {

        public IdentityFrameworkUserManager(IUserStore<IdentityFrameworkUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<IdentityFrameworkUser> passwordHasher, IEnumerable<IUserValidator<IdentityFrameworkUser>> userValidators, IEnumerable<IPasswordValidator<IdentityFrameworkUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<IdentityFrameworkUser>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }
    }
}
