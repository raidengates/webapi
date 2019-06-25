using System;
using System.Collections.Generic;
using System.Text;

namespace Unititi.Framework.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string JwtIssuer { get; set; }
        public string JwtExpiryInMinutes { get; set; }
    }
}
