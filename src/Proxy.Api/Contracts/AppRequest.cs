using System;

namespace Proxy.Api.Contracts
{
    public class AppRequest
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}