using Business;
using Business.Interfaces;
using GTIEntity;
using System.Collections.Generic;
using System.Web.Http;

namespace API.Controllers
{

    public class ClienteController : ApiController
    {
        IClienteBusiness _clienteBusiness = new ClienteBusiness();

        // GET: api/Cliente
        public IEnumerable<Cliente> Get()
        {
            return _clienteBusiness.BuscarTodos();
        }

        // GET: api/Cliente/5
        public Cliente Get(int id)
        {
            return _clienteBusiness.BuscarPorId(id);
        }

        // POST: api/Cliente
        public void Post([FromBody] Cliente cliente)
        {
            _clienteBusiness.Inserir(cliente);
        }

        // PUT: api/Cliente/5
        public void Put( [FromBody] Cliente cliente)
        {
            _clienteBusiness.Atualizar(cliente);
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
            _clienteBusiness.Excluir(id);
        }
    }
}
