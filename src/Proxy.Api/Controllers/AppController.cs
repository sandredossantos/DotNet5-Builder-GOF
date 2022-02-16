using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Proxy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> GetApp()
        {
            return Ok();
        }
    }
}