using Business.Interfaces;
using GTIData;
using GTIEntity;
using System.Collections.Generic;
using System.Threading;

namespace Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        public void Atualizar(Cliente cliente)
        {
            ClienteData clienteData = new ClienteData();
          
            clienteData.Atualizar(cliente);
        }

        public Cliente BuscarPorId(int Id)
        {
            ClienteData clienteData = new ClienteData();
            return clienteData.BuscarPorId(Id);
        }

        public IEnumerable<Cliente> BuscarTodos()
        {
            ClienteData clienteData = new ClienteData();
            return clienteData.BuscarTodos();
        }

        public void Excluir(int id)
        {
            ClienteData clienteData = new ClienteData();
            clienteData.Excluir(id);
        }

        public void Inserir(Cliente a)
        {
            ClienteData clienteData = new ClienteData();
            clienteData.Inserir(a);
        }
    }
}
