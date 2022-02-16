using Microsoft.AspNetCore.Mvc;
using Proxy.Api.Contracts;
using Proxy.Api.Services;
using System;
using System.Threading.Tasks;

namespace Proxy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppsController : ControllerBase
    {
        private readonly IAppService _service;

        public AppsController(IAppService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> GetApp([FromBody] AppRequest request)
        {
            var response = await _service.Post(request);
            return Ok(response);
        }
    }
}