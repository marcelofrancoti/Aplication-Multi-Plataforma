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
    public class ConsumoAPICliente
    {
        HttpClient client = new HttpClient();

        public void InsieriCientes(Cliente cliente)
        {

        }

        public Paged<Cliente> GetClientes(string descricao = "", int pageSize = 0, int pageNumber = 0)
        {
            HttpResponseMessage result = client.GetAsync(@"https://localhost:44314/API/Cliente").Result;
            var varJson = result.Content.ReadAsStringAsync();


            IEnumerable<Cliente> clienteList = JsonConvert.DeserializeObject<IEnumerable<Cliente>>(varJson.Result) as IEnumerable<Cliente>;
          
            Paged<Cliente> paged = new Paged<Cliente>()
            {
                List = clienteList
            };
            return paged;
        }

        public Cliente GetClientePorId(int id)
        {
            HttpResponseMessage result = client.GetAsync(@"https://localhost:44314/API/Cliente?id=" + id).Result;
            var varJson = result.Content.ReadAsStringAsync();
            Cliente cliente = JsonConvert.DeserializeObject<Cliente>(varJson.Result);
            return cliente;
        }

    }
}