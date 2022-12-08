using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using GTIEntity;
using System.Text;
using System.Security.Policy;
using RestSharp;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Web.UI.WebControls;
using MVCWEB.Models;

namespace MVCWEB.Services
{
    public class ConsumoAPICliente : IConsumo<Cliente>
    {
        HttpClient _client = new HttpClient();
        public ConsumoAPICliente()
        {
            _client.BaseAddress = new Uri("https://localhost:44314/");
        }

        public IEnumerable<Cliente> Get()
        {
            HttpResponseMessage result = _client.GetAsync(@"API/Cliente").Result;
            var varJson = result.Content.ReadAsStringAsync();
            IEnumerable<Cliente> clienteList = JsonConvert.DeserializeObject<IEnumerable<Cliente>>(varJson.Result) as IEnumerable<Cliente>;
            return clienteList;
        }

        public Cliente GetPorId(int id)
        {
            HttpResponseMessage result = _client.GetAsync(@"API/Cliente?id=" + id).Result;
            var varJson = result.Content.ReadAsStringAsync();
            Cliente cliente = JsonConvert.DeserializeObject<Cliente>(varJson.Result);
            return cliente;
        }

        public void Inserir(Cliente clienteP)
        {
            var clienteJson = JsonConvert.SerializeObject(clienteP);
            var buffer = System.Text.Encoding.UTF8.GetBytes(clienteJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage result = _client.PostAsync(@"API/Cliente", byteContent).Result;
            var varJson = result.Content.ReadAsStringAsync();

        }

        public void Alterar(Cliente clienteP)
        {
            var clienteJson = JsonConvert.SerializeObject(clienteP);
            var buffer = System.Text.Encoding.UTF8.GetBytes(clienteJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage result = _client.PutAsync(@"API/Cliente", byteContent).Result;
            var varJson = result.Content.ReadAsStringAsync();
        }

        internal void Excluir(int id)
        {
            HttpResponseMessage result = _client.DeleteAsync(@"API/Cliente?id=" + id).Result;
        }
    }
}