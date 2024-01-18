using Microsoft.AspNetCore.Mvc;
using IDMApi.Data;
using IDMApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace IDMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Produces("application/json")]
    [EnableCors("Mypolicy")]
    public class DetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<DetailsController> _logger;

        public DetailsController(ApplicationDbContext dbContext, ILogger<DetailsController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

       

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employees = await _dbContext.Employee.ToListAsync();
            return Ok(employees);
        }

        }
    }

