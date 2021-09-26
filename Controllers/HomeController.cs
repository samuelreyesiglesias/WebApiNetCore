using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNetCore.Controllers
{
    [Route("api/home")]
    public class HomeController : Controller
    {
        [Produces("text/plain")]
        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            try
            {
                var content = "Hello world";
                return Ok(content);
            }catch(Exception Ex)
            {
                return BadRequest();
            }
        }
    }
}
