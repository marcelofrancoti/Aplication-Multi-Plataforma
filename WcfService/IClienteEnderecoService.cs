using GTIEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IClienteEnderecoService" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IClienteEnderecoService
    {
        [OperationContract]
        IEnumerable<ClienteEndereco> Get();
        [OperationContract]
        ClienteEndereco GetPorId(int id);
        [OperationContract]
        void Post(ClienteEndereco clienteEndereco);
        [OperationContract]
        void Put(ClienteEndereco clienteEndereco);
        [OperationContract]
        void Delete(int id);
    }
}
