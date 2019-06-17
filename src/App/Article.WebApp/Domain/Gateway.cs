using System;
using System.Collections.Generic;
using System.Text;

namespace Article.WebApp.Domain
{
    public class Gateway
    {
        public string DownstreamScheme { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }

    }
}
