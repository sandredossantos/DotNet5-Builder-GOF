using System;
using System.Net.Http;

namespace Proxy.Integration.RestConfiguration
{
    public class RestServiceConfigurationBuilder
    {
        private readonly RestServiceConfiguration _config;

        public RestServiceConfigurationBuilder()
        {
            _config = new RestServiceConfiguration();
        }

        public RestServiceConfiguration Build()
        {
            return _config;
        }

        /// <summary>
        /// Is the endpoint of your request.
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder Uri(Uri uri)
        {
            _config.Uri = uri;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder TimeOut(TimeSpan timeout)
        {
            _config.TimeOut = timeout;
            return this;
        }

        /// <summary>
        /// Are the headers of your request.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder Headers(string key, string value)
        {
            _config.Headers.Add(key, value);
            return this;
        }

        /// <summary>
        /// Is the payload that will be sent.
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder Payload(string payload)
        {
            _config.Payload = payload;
            return this;
        }

        /// <summary>
        /// Is the verb of the http protocol that will be used.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder Method(HttpMethod method)
        {
            _config.Method = method;
            return this;
        }
    }
}