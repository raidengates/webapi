using System;

namespace Identity.WebApi.Models
{
    public class SecurityToken
    {
        public string auth_token { get; set; }
        public TimeSpan expirationTime { get; set; }
    }
}
