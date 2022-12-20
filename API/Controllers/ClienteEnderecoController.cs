using Business.Interfaces;
using System.Collections.Generic;
using System.Web.Http;
using Entity;

namespace API.Controllers
{
    public class ClienteEnderecoController : ApiController
    {
        IClienteEnderecoBusiness _clienteBusiness;
        public ClienteEnderecoController(IClienteEnderecoBusiness clienteEnderecoBusiness)
        {
            _clienteBusiness = clienteEnderecoBusiness;
        }

        // GET: api/ClienteEndereco
        public IEnumerable<ClienteEndereco> Get()
        {
            return _clienteBusiness.BuscarTodos();
        }

        // GET: api/ClienteEndereco/5
        public ClienteEndereco Get(int id)
        {
            return _clienteBusiness.BuscarPorId(id);
        }

        // POST: api/ClienteEndereco
        public void Post([FromBody] ClienteEndereco clienteEndereco)
        {
            _clienteBusiness.Inserir(clienteEndereco);
        }

        // PUT: api/ClienteEndereco/5
        public void Put([FromBody] ClienteEndereco clienteEndereco)
        {
            _clienteBusiness.Inserir(clienteEndereco);
        }

        // DELETE: api/ClienteEndereco/5
        public void Delete(int id)
        {
            _clienteBusiness.Excluir(id);
        }
    }
}
