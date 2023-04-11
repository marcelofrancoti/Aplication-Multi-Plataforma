using Business.Interfaces;
using Data;
using Entity;
using System.Collections.Generic;

namespace Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly ClienteData clienteData;

        public ClienteBusiness()
        {
            clienteData = new ClienteData();
        }

        public void Atualizar(Cliente cliente)
        {
            clienteData.Atualizar(cliente);
        }

        public Cliente BuscarPorId(int Id)
        {
            return clienteData.BuscarPorId(Id);
        }

        public IEnumerable<Cliente> BuscarTodos()
        {
            try
            {
                return clienteData.BuscarTodos();
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public void Excluir(int id)
        {
            clienteData.Excluir(id);
        }

        public void Inserir(Cliente a)
        {
            clienteData.Inserir(a);
        }
    }
}
