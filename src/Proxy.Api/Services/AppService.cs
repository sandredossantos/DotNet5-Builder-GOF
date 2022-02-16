using Proxy.Integration.Clients.AppOneClient;
using Proxy.Integration.RestConfiguration;
using Proxy.Integration.RestService;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Proxy.Api.Services
{
    public class AppService : IAppService
    {
        private readonly IAppOneClient _client;

        public AppService(IAppOneClient client)
        {
            _client = client;
        }

        public Task Get()
        {
            throw new NotImplementedException();
        }
    }
}