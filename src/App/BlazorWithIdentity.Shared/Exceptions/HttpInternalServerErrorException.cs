using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Blazor.Shared.Exceptions
{
    public class HttpInternalServerErrorException : HttpRequestException
    {
        public HttpInternalServerErrorException() : base("500 (Internal Server Error)") { }
    }
}
