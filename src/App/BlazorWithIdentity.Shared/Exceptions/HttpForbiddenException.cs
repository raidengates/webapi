using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Blazor.Shared.Exceptions
{
    public class HttpForbiddenException : HttpRequestException
    {
        public HttpForbiddenException() : base("403 (Forbidden)") { }
    }
}
