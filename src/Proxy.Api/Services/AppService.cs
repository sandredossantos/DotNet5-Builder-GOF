using Newtonsoft.Json;
using Proxy.Api.Contracts;
using Proxy.Integration.RestConfiguration;
using Proxy.Integration.RestService;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Proxy.Api.Services
{
    public class AppService : IAppService
    {
        private readonly IRestService _restService;

        public AppService(IRestService restService)
        {
            _restService = restService;
        }

        public async Task<AppResponse> Post(AppRequest request)
        {
            var payload = JsonConvert.SerializeObject(request);

            var config = new RestServiceConfigurationBuilder()
                .AddUri(new Uri("https://webhook.site/5dc3d3e5-84dd-4b9d-acf6-072ad98b8cb3"))
                .AddPayload(payload.ToString())
                .AddVerb(HttpMethod.Post)
                .AddTimeOut(TimeSpan.FromSeconds(3))                
                .Build();

            var response = await _restService.ExecuteAsync(config);
            var content = await response.Content.ReadAsStringAsync();                       

            return JsonConvert.DeserializeObject<AppResponse>(content);
        }
    }
}