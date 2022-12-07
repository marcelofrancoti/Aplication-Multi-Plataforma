using Business.Interfaces;
using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GTIEntity;

namespace API.Controllers
{
    public class ClienteEnderecoController : ApiController
    {
        IClienteEnderecoBusiness _clienteBusiness = new ClienteEnderecoBusiness();

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
        public void Post([FromBody]ClienteEndereco clienteEndereco)
        {
            _clienteBusiness.Inserir(clienteEndereco);
        }

        // PUT: api/ClienteEndereco/5
        public void Put([FromBody]ClienteEndereco clienteEndereco)
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
