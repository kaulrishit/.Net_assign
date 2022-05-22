using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cricketApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cricketApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly cricketContext _cricketcontext;
        public MatchesController(cricketContext cricketcontext)
        {
            _cricketcontext = cricketcontext;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var getMatches = _cricketcontext.Matches.ToList();
            return Ok(getMatches);
        }

        // GET: api/Matches/5
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //  return "value";
        // }

        // POST: api/Matches
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Matches/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
