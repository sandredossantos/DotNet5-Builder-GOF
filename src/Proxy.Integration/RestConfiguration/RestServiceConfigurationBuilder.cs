using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Proxy.Integration.RestConfiguration
{
    /// <summary>
    /// 
    /// </summary>
    public class RestServiceConfigurationBuilder
    {
        private readonly RestServiceConfiguration _config;

        public RestServiceConfigurationBuilder()
        {
            _config = new RestServiceConfiguration();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public RestServiceConfiguration Build()
        {
            return _config;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder AddUri(Uri uri)
        {
            _config.Uri = uri;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder AddTimeOut(TimeSpan timeout)
        {
            _config.TimeOut = timeout;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder AddHeader(string key, string value)
        {
            _config.Headers.Add(key, value);
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="headers"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder AddHeader(IDictionary<string, string> headers)
        {
            _config.Headers = headers;
            return this;
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="payload"></param>
       /// <returns></returns>
        public RestServiceConfigurationBuilder AddPayload(string payload)
        {
            _config.Payload = payload;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder AddVerb(HttpMethod method)
        {
            _config.Method = method;
            return this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public RestServiceConfigurationBuilder AddQueryParameter(string key, string value)
        {
            _config.Parameters.Add(key, value);
            return this;
        }
    }
}