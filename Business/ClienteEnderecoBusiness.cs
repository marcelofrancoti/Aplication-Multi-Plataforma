using Business.Interfaces;
using Data;
using Entity;
using System.Collections.Generic;

namespace Business
{
    public class ClienteEnderecoBusiness : IClienteEnderecoBusiness
    {
        public void Atualizar(ClienteEndereco a)
        {
            ClienteEnderecoData clienteEnderecoData = new ClienteEnderecoData();
            clienteEnderecoData.Atualizar(a);
        }

        public ClienteEndereco BuscarPorId(int Id)
        {
            ClienteEnderecoData clienteEnderecoData = new ClienteEnderecoData();
            return clienteEnderecoData.BuscarPorId(Id);
        }

        public IEnumerable<ClienteEndereco> BuscarTodos()
        {
            ClienteEnderecoData clienteEnderecoData = new ClienteEnderecoData();
            return clienteEnderecoData.BuscarTodos();
        }

        public void Excluir(int id)
        {
            ClienteEnderecoData clienteEnderecoData = new ClienteEnderecoData();
            clienteEnderecoData.Excluir(id);
        }

        public void Inserir(ClienteEndereco a)
        {
            ClienteEnderecoData clienteEnderecoData = new ClienteEnderecoData();
            clienteEnderecoData.Inserir(a);
        }
    }
}
