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
        public string Get()
        {

            var message = "Ovo je poruka";

            return message;
        }
    }
}
