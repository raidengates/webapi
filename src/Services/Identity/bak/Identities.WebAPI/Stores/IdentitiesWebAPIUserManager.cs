using Identities.WebAPI.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Identities.WebAPI.Stores
{
    public class IdentitiesWebAPIUserManager : UserManager<IdentitiesWebAPIUser>
    {


        public IdentitiesWebAPIUserManager(IUserStore<IdentitiesWebAPIUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<IdentitiesWebAPIUser> passwordHasher, IEnumerable<IUserValidator<IdentitiesWebAPIUser>> userValidators, IEnumerable<IPasswordValidator<IdentitiesWebAPIUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<IdentitiesWebAPIUser>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }
    }
}
