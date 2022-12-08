using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;

namespace MVCWEB.Services
{
    public interface IConsumo<T>
    {
     
        IEnumerable<T> Get();

        T GetPorId(int id);

        void Inserir(T Parametro);

        void Alterar(T Parametro);
    }
}
