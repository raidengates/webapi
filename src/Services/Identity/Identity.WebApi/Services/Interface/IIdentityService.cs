using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.WebApi.Services
{
    public interface IIdentityService
    {
        Models.SecurityToken Authenticate(string username, string password, HttpContext context);
    }

}
