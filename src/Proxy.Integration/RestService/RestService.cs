using Proxy.Integration.RestConfiguration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Integration.RestService
{
    public class RestService : IRestService
    {
        public Task<HttpResponseMessage> DeleteAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<HttpResponseMessage> PostAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<HttpResponseMessage> PutAsync()
        {
            throw new System.NotImplementedException();
        }

        private HttpClient CreateHttpClient(RestServiceConfiguration config)
        {
            HttpClient httpClient = new();

            httpClient.Timeout = config.TimeOut;
            httpClient.BaseAddress = config.Uri;
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")
            {
                CharSet = Encoding.UTF8.WebName
            });

            foreach(var header in config.Headers)
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);
            }

            return httpClient;
        }
    }
}