using System;
using System.Threading.Tasks;

namespace Proxy.Integration.Clients.AppTwoClient
{
    public class AppTwoClient : IAppTwoClient
    {
        public Task GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}