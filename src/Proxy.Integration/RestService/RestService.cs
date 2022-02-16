using Proxy.Integration.RestConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Integration.RestService
{
    public class RestService : IRestService
    {
        public async Task<HttpResponseMessage> ExecuteAsync(RestServiceConfiguration config)
        {
            var httpclient = CreateHttpClient(config);

            if (config.Method == HttpMethod.Get)
            {
                return await httpclient.GetAsync(config.Uri);
            }

            if (config.Method == HttpMethod.Post)
            {
                return await httpclient.PostAsJsonAsync(config.Uri, config.Payload);
            }

            if (config.Method == HttpMethod.Put)
            {
                return await httpclient.PutAsJsonAsync(config.Uri, config.Payload);
            }

            if (config.Method == HttpMethod.Delete)
            {
                return await httpclient.DeleteAsync(config.Uri);
            }

            throw new System.NotImplementedException("O verbo informado não está habilitado");
        }

        private static HttpClient CreateHttpClient(RestServiceConfiguration config)
        {
            HttpClient httpClient = new();

            httpClient.Timeout = config.TimeOut;
            httpClient.BaseAddress = config.Uri;
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")
            {
                CharSet = Encoding.UTF8.WebName
            });

            foreach (var header in config.Headers)
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);
            }

            return httpClient;
        }
    }
}