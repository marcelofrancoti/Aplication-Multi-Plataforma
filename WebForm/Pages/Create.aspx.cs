using System;
using System.Linq;

namespace WebForm
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void VoltarButton_Click(object sender, EventArgs e)
        {
            // Redirecionar para a página desejada
            Response.Redirect("~/CadCliente/Index");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ServiceReferencesCliente.ClienteService clienteService = new ServiceReferencesCliente.ClienteService();
            ServiceReferencesClienteEndereco.ClienteEnderecoService clienteEnderecoService = new ServiceReferencesClienteEndereco.ClienteEnderecoService();

            ServiceReferencesCliente.Cliente cliente = new ServiceReferencesCliente.Cliente();
            ServiceReferencesClienteEndereco.ClienteEndereco clienteEndereco = new ServiceReferencesClienteEndereco.ClienteEndereco();

            cliente.Nome = NomeTextBox.Text;
            cliente.CPF = CPFTextBox.Text;
            cliente.RG = RGTextBox.Text;
            cliente.Data_Expedicao = DataExpedicaoTextBox.Text;
            cliente.Orgao_Expedicao = OrgaoExpedicaoTextBox.Text;
            cliente.UF = UFTextBox.Text;
            cliente.Data_de_Nascimento = DataNascimentoTextBox.Text;
            cliente.Sexo = SexoDropDownList.SelectedValue;
            cliente.Estado_Civil = EstadoCivilDropDownList.SelectedValue;

            clienteEndereco.CEP = CEPTextBox.Text;
            clienteEndereco.Logradouro = LogradouroTextBox.Text;
            clienteEndereco.Numero = NumeroTextBox.Text;
            clienteEndereco.Complemento = ComplementoTextBox.Text;
            clienteEndereco.Bairro = BairroTextBox.Text;
            clienteEndereco.Cidade = CidadeTextBox.Text;
            clienteEndereco.UF = UFEnderecoTextBox.Text;

            clienteService.Post(cliente);

            var clienteInserido = clienteService.Get().Where(f => f.CPF == cliente.CPF).FirstOrDefault();

            clienteEndereco.ClienteId = clienteInserido.ClienteId;

            clienteEnderecoService.Post(clienteEndereco);

            Response.Redirect("~/CadCliente/Index");
        }

    }
}
