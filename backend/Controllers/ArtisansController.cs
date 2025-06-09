using Microsoft.AspNetCore.Mvc;
using backend.Models;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtisansController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Artisan>> Get()
        {
            return Ok(Artisan.All);
        }
    }
}
