using System.Threading.Tasks;

namespace Proxy.Integration.Clients.AppTwoClient
{
    public interface IAppTwoClient
    {
        Task GetAsync();
        Task PostAsync();
    }
}