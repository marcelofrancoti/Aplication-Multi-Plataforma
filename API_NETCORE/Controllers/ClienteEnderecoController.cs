using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_NETCORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteEnderecoController : ControllerBase
    {
        // GET: api/<ClienteEnderecoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClienteEnderecoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClienteEnderecoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClienteEnderecoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClienteEnderecoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
