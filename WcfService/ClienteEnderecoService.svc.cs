using Business;
using Business.Interfaces;
using Entity;
using System.Collections.Generic;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "ClienteEnderecoService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione ClienteEnderecoService.svc ou ClienteEnderecoService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ClienteEnderecoService : IClienteEnderecoService
    {
        IClienteEnderecoBusiness _clienteBusiness;

        public ClienteEnderecoService(IClienteEnderecoBusiness clienteEnderecoBusiness)
        {
            _clienteBusiness = clienteEnderecoBusiness;
        }


        public void Delete(int id)
        {
            _clienteBusiness.Excluir(id);
        }

        public IEnumerable<ClienteEndereco> Get() => _clienteBusiness.BuscarTodos();

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
