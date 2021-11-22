using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
