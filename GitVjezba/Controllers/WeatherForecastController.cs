using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitVjezba.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Message : ControllerBase
    {
       

        [HttpGet]
        public List<string> Get()
        {
            List<string> names = new List<string>
            {
                "Matija",
                "Armin",
                "Ammar"
            };

            return names;
        }
    }
}
