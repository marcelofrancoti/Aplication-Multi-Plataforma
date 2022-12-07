using Business;
using Business.Interfaces;
using GTIEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    public class ClienteService : IClienteService
    {
        IClienteBusiness _clienteBusiness = new ClienteBusiness();

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
