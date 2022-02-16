using Proxy.Api.Contracts;
using System;
using System.Threading.Tasks;

namespace Proxy.Api.Services
{
    public interface IAppService
    {
        Task<AppResponse> Post(AppRequest request);
    }
}