using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Blazor.Shared.Exceptions
{
    public class HttpUnauthorizedException : HttpRequestException
    {
        public HttpUnauthorizedException() : base("401 (Unauthorized)") { }
    }
}
