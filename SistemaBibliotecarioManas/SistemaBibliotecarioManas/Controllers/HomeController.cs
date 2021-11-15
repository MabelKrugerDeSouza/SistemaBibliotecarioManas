using Microsoft.AspNetCore.Mvc;

namespace SistemaBibliotecarioManas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult Get()
        {
            return Ok("OK");
        }
    }
}
