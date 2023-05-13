using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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
        public string Perofile()
        {
            return "Dua lipa is a Perfole and its her profile";
        }
        [HttpGet]
        [Route("soangs")]
        public List<string> songs()
        {
            List<string> songs = new List<string>();
            songs.Add("Levitating");
            songs.Add("get loose");
            songs.Add("it the time to AUdnjn");


            return songs;
        }
    }
}
