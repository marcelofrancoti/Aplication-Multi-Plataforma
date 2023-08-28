using Business.Interfaces;
using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    public class ClienteEnderecoService : IClienteEnderecoService
    {
        IClienteEnderecoBusiness _clienteBusiness;

        public ClienteEnderecoService()
        {
            _clienteBusiness = new ClienteEnderecoBusiness();
        }
   
        public void Delete(int id)
        {
            _clienteBusiness.Excluir(id);
        }

        public IEnumerable<ClienteEndereco> Get()
        {
            return _clienteBusiness.BuscarTodos();
        }

        public ClienteEndereco GetPorId(int id)
        {
            return _clienteBusiness.BuscarPorId(id);
        }

        public void Post(ClienteEndereco clienteEndereco)
        {
            _clienteBusiness.Inserir(clienteEndereco);
        }

        public void Put(ClienteEndereco clienteEndereco)
        {
            _clienteBusiness.Atualizar(clienteEndereco);
        }
    }
}
