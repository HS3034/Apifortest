using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Apifortest.Models;

namespace Apifortest.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
   
    public class MembersController :ControllerBase
    {
        readonly AppcontextDb _dbContext;
        public MembersController( AppcontextDb dbContext)
        {
            _dbContext = dbContext;
        }

          [HttpGet]
        public async Task<ActionResult<IEnumerable<Member>>> GetMember() {
     
            return await _dbContext.members.ToListAsync();
        }

        [HttpGet("{id}")]
        
        public async Task<ActionResult<Member>> GetMember(int id)
        {
            var pd = await _dbContext.members.FindAsync(id);

            if (pd == null)
            {
                return NotFound();
            }

            return pd;
        }
        [HttpPost]
        public async Task<IActionResult> Register(Member Model) {

            _dbContext.members.Add(Model);
            await _dbContext.SaveChangesAsync();

            return Ok(Model);
        }
    }
}