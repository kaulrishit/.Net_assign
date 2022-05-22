using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cricketApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cricketApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        // GET: api/Player
        private readonly cricketContext _cricketcontext;
        public PlayerController(cricketContext cricketcontext)
        {
            _cricketcontext = cricketcontext;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var getPlayer = _cricketcontext.Player.ToList();
            return Ok(getPlayer);
        }

        // GET: api/Player/5
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //   return "value";
        // }

        // POST: api/Player
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Player/5
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
