using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using Entity;

namespace MVCWEB.Services
{
    public interface IConsumo<T>
    {
     
        IEnumerable<T> Get();

        T GetPorId(int id);

        void Alterar(T Parametro);
        HttpResponseMessage InserirHttpResponse(T Parametro);
    }
}
