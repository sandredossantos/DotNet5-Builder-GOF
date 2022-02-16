using Proxy.Integration.RestConfiguration;
using Proxy.Integration.RestService;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Proxy.Integration.Clients.AppOneClient
{
    public class AppOneClient : IAppOneClient
    {
        private readonly IRestService _restService;
        private static RestServiceConfigurationBuilder config;

        public AppOneClient(IRestService restService)
        {
            _restService = restService;
        }

        public AppOneClient()
        {
            var config = new RestServiceConfigurationBuilder()
                .Uri(new Uri(""))
                .TimeOut(TimeSpan.FromSeconds(3))
                .Payload("")
                .Headers("", "")
                .Method(HttpMethod.Post)
                .Build();
        }
        public Task GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}