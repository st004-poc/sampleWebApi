using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Message = "Hello Hello Brother!! This is from ASP.NET Core 8 API 🚀",
                Date = DateTime.UtcNow
            });
        }
    }
}
