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
        //public Gateway()
        //{
        //    DownstreamScheme = string.IsNullOrEmpty(DownstreamScheme) ? "http": DownstreamScheme;
        //    Host = string.IsNullOrEmpty(Host) ? "localhost" : Host;
        //    Port = string.IsNullOrEmpty(Port) ? "44301" : Port;
        //}
    }
}
