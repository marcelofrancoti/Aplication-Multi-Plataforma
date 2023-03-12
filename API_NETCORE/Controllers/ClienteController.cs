using Business;
using Business.Interfaces;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_NETCORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        IClienteBusiness _clienteBusiness ;
        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _clienteBusiness.BuscarTodos();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return _clienteBusiness.BuscarPorId(id);
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            _clienteBusiness.Inserir(cliente);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Cliente cliente)
        {
            _clienteBusiness.Atualizar(cliente);
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clienteBusiness.Excluir(id);
        }
    }
}
