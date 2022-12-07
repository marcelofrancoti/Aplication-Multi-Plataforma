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
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        IEnumerable<Cliente> Get();

        [OperationContract]
        Cliente GetPorId(int id);

        [OperationContract]
        void Post(Cliente cliente);

        [OperationContract]
        void Put(Cliente cliente);

        [OperationContract]
        void Delete(int id);

    }

}
