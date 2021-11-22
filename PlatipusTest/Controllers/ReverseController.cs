using Microsoft.AspNetCore.Mvc;

namespace PlatipusTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReverseController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetReverseData(string data)
        {
            return Ok(data);
        }
    }
}
