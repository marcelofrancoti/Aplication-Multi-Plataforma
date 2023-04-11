using Business.Interfaces;
using Data;
using Entity;
using System.Collections.Generic;

namespace Business
{
    public class ClienteEnderecoBusiness : IClienteEnderecoBusiness
    {
        private readonly ClienteEnderecoData clienteEnderecoData;

        public ClienteEnderecoBusiness()
        {
            clienteEnderecoData = new ClienteEnderecoData();
        }

        public void Atualizar(ClienteEndereco a)
        {
            clienteEnderecoData.Atualizar(a);
        }

        public ClienteEndereco BuscarPorId(int Id)
        {
            return clienteEnderecoData.BuscarPorId(Id);
        }

        public IEnumerable<ClienteEndereco> BuscarTodos()
        {
            return clienteEnderecoData.BuscarTodos();
        }

        public void Excluir(int id)
        {
            clienteEnderecoData.Excluir(id);
        }

        public void Inserir(ClienteEndereco a)
        {
            clienteEnderecoData.Inserir(a);
        }
    }
}
