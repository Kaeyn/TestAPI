using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLUTESTAPI.Models;

namespace VLUTESTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
               
        private readonly ApplicationDbContext _applicationDbContext;

        public TestController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    

        [HttpPost("GetAllProduct")]
        public async Task<IActionResult> GetAllEmpoyee()
        {
            var employee = await _applicationDbContext.Product.ToListAsync();
            return Ok(employee);

        }


    }
}
