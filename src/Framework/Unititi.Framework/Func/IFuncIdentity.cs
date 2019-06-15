using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Unititi.Framework.Models;

namespace Unititi.Framework.Func
{
    public interface IFuncIdentity
    {
        string CreateSecurityTokenDescriptor(IdentityModel _identityModel, byte[] SecretKey);

        IdentityModel GetAuthorizationHeader(string authorizationHeader);

    }
}
