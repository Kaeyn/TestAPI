using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VLUTESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarmupController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Warmup successfully !");         
        }
    }
}
