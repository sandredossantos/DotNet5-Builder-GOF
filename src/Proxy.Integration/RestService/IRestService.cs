using Proxy.Integration.RestConfiguration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Proxy.Integration.RestService
{
    public interface IRestService
    {        
        Task<HttpResponseMessage> GetAsync();
        Task<HttpResponseMessage> PostAsync();
        Task<HttpResponseMessage> PutAsync();
        Task<HttpResponseMessage> DeleteAsync();
    }
}