using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using GTIEntity;

namespace MVCWEB.Services
{
    public class ConsumoAPIClienteEndereco : IConsumo<ClienteEndereco>
    {

        private HttpClient _client = new HttpClient();

        public ConsumoAPIClienteEndereco()
        {
            _client.BaseAddress = new Uri("https://localhost:44314/");
        }


        public IEnumerable<ClienteEndereco> Get()
        {
            HttpResponseMessage result = _client.GetAsync(@"API/ClienteEndereco").Result;
            var varJson = result.Content.ReadAsStringAsync();
            IEnumerable<ClienteEndereco> clienteList = JsonConvert.DeserializeObject<IEnumerable<ClienteEndereco>>(varJson.Result) as IEnumerable<ClienteEndereco>;
            return clienteList;
        }

        public IEnumerable<ClienteEndereco> GetPorId(int id)
        {
            HttpResponseMessage result = _client.GetAsync(@"API/ClienteEndereco").Result;
            var varJson = result.Content.ReadAsStringAsync();

            IEnumerable<ClienteEndereco> clienteList = JsonConvert.DeserializeObject<IEnumerable<ClienteEndereco>>(varJson.Result);
            return clienteList.Where(f => f.ClienteId == id).ToList();
        }

        public void Inserir(ClienteEndereco clienteEnderecoP)
        {
            var clienteJson = JsonConvert.SerializeObject(clienteEnderecoP);
            var buffer = System.Text.Encoding.UTF8.GetBytes(clienteJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage result = _client.PostAsync(@"API/ClienteEndereco", byteContent).Result;
            var varJson = result.Content.ReadAsStringAsync();

        }

        public void Alterar(ClienteEndereco clienteEnderecoP)
        {
            var clienteJson = JsonConvert.SerializeObject(clienteEnderecoP);
            var buffer = System.Text.Encoding.UTF8.GetBytes(clienteJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage result = _client.PutAsync(@"API/ClienteEndereco", byteContent).Result;
            var varJson = result.Content.ReadAsStringAsync();

        }

        ClienteEndereco IConsumo<ClienteEndereco>.GetPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}