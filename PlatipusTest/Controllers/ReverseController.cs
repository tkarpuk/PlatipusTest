using Microsoft.AspNetCore.Mvc;
using Platipus.BLL;
using System;
using System.Text.Json;

namespace PlatipusTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReverseController : ControllerBase
    {
        private readonly ReverseService _reverseService;
        public ReverseController(ReverseService reverseService) => _reverseService = reverseService;

        [HttpGet]
        public IActionResult GetReverseData(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return BadRequest("Empty input data");
            }

            try
            {
                object result = _reverseService.GetResult(data);
                return Ok(JsonSerializer.Serialize(result));
            }
            catch (Exception e)
            {
                return NotFound("Internal error: " + e.Message);
            }           
        }
    }
}
