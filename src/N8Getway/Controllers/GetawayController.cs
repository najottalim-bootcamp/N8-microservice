using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace N8Getway.Controllers
{
    [Route("api/getway")]
    [ApiController]
    public class GetawayController : ControllerBase
    {
        [HttpGet]
        public IActionResult Getaway()
        {
            return Ok("sigap");
        }
    }
}
