using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Proxy.Integration.RestConfiguration
{
    public class RestServiceConfiguration
    {

        public Uri Uri { get; set; }
        public TimeSpan TimeOut { get; set; }
        public HttpMethod Method { get; set; }
        public string Payload { get; set; }
        public IDictionary<string, string> Headers { get; set; }
        public IDictionary<string, string> Parameters { get; set; }

        public RestServiceConfiguration()
        {
            Headers = new Dictionary<string, string>();
            Parameters = new Dictionary<string, string>();
        }
    }
}