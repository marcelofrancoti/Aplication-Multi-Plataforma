using Business.Interfaces;
using Entity;
using System.Collections.Generic;

namespace WcfService
{
    public class ClienteService : IClienteService
    {
        IClienteBusiness _clienteBusiness;

        public ClienteService(IClienteBusiness clienteBusiness)
        {
            _clienteBusiness = clienteBusiness;
        }

        public IEnumerable<Cliente> Get()
        {
            return _clienteBusiness.BuscarTodos();
        }

        public Cliente GetPorId(int id)
        {
            return _clienteBusiness.BuscarPorId(id);
        }

        public void Post(Cliente cliente)
        {
            _clienteBusiness.Inserir(cliente);
        }

        public void Put(Cliente cliente)
        {
            _clienteBusiness.Atualizar(cliente);
        }

        public void Delete(int id)
        {
            _clienteBusiness.Excluir(id);
        }

    }
}
