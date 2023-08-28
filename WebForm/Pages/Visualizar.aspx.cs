using System;
using System.Data;
using System.Diagnostics;
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

        private void CarregarClientes()
        {

            ServiceReferencesCliente.ClienteService clienteService = new ServiceReferencesCliente.ClienteService();

            var clientes = clienteService.Get();
            ClientesGridView.DataSource = clientes;
            ClientesGridView.DataBind();
        }


    }
}
