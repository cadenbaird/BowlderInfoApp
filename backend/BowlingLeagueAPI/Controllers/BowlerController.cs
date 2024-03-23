using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BowlingLeagueAPI.Models;
using Microsoft.EntityFrameworkCore; // Assuming Bowler is part of the Models and requires EntityFrameworkCore for ToListAsync()

namespace BowlingLeagueAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private readonly BowlingLeagueContext _context;

        public BowlerController(BowlingLeagueContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bowlers>>> GetBowlers()
        {
            return await _context.Bowlers.ToListAsync();
        }
    }
}