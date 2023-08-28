using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class Visualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarClientes();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        public void CarregarClientes()
        {
            ServiceReferencesCliente.ClienteService clienteService = new ServiceReferencesCliente.ClienteService();
            ServiceReferencesClienteEndereco.ClienteEnderecoService clienteEnderecoService = new ServiceReferencesClienteEndereco.ClienteEnderecoService();

            List<WebForm.ClienteCompleto> clientesCompletos = new List<WebForm.ClienteCompleto>();

            var TodosEnderecos = clienteEnderecoService.Get();
            var todosClientes = clienteService.Get();

            foreach (var cliente in todosClientes)
            {
                WebForm.ClienteCompleto clienteCompleto = new WebForm.ClienteCompleto();

                clienteCompleto.Nome = cliente.Nome;
                clienteCompleto.CPF = cliente.CPF;
                clienteCompleto.UF = cliente.UF;
                clienteCompleto.Estado_Civil = cliente.Estado_Civil;
                clienteCompleto.Data_de_Nascimento = cliente.Data_de_Nascimento;
                clienteCompleto.Data_Expedicao = cliente.Data_Expedicao;
                clienteCompleto.Orgao_Expedicao = cliente.Orgao_Expedicao;
                clienteCompleto.Sexo = cliente.Sexo;
                clienteCompleto.ClienteId = cliente.ClienteId;
                clienteCompleto.ClienteEndereco = new List<ServiceReferencesClienteEndereco.ClienteEndereco>();
                clienteCompleto.ClienteEndereco.Add(TodosEnderecos.Select(f => f).Where(f => f.ClienteId == cliente.ClienteId).FirstOrDefault());

                clientesCompletos.Add(clienteCompleto);
            }

            ClientesRepeater.DataSource = clientesCompletos;
            ClientesRepeater.DataBind();
        }


        protected void alterar_Command(object sender, CommandEventArgs e)
        {
            int clienteId = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("Alterar.aspx?ClienteId=" + clienteId);
        }
    }
}
