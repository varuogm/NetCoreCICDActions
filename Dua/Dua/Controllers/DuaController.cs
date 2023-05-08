using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dua.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DuaController : ControllerBase
    {
      
        [HttpGet]
        public string InitialPage()
        {
            return "This is Dua initial page";
        }

        [HttpGet]
        [Route("profile")]
        public string profile()
        {
            return "Dua lipa is a singer and its her profile";
        }
    }
}
