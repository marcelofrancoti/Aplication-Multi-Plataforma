using System;


namespace WebForm
{
    public partial class Alterar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int clienteId;
                if (int.TryParse(Request.QueryString["ClienteId"], out clienteId))
                {
                    ServiceReferencesCliente.ClienteService clienteService = new ServiceReferencesCliente.ClienteService();
                    ServiceReferencesClienteEndereco.ClienteEnderecoService clienteEnderecoService = new ServiceReferencesClienteEndereco.ClienteEnderecoService();

                    var endereco = clienteEnderecoService.GetPorId(clienteId);
                    var cliente = clienteService.GetPorId(clienteId);

                    NomeTextBox.Text = cliente.Nome;
                    CPFTextBox.Text = cliente.CPF;
                    RGTextBox.Text = cliente.RG;
                    DataExpedicaoTextBox.Text = cliente.Data_Expedicao;
                    OrgaoExpedicaoTextBox.Text = cliente.Orgao_Expedicao;
                    UFTextBox.Text = cliente.UF;
                    DataNascimentoTextBox.Text = cliente.Data_de_Nascimento;
                    SexoDropDownList.SelectedValue = cliente.Sexo;
                    EstadoCivilDropDownList.SelectedValue = cliente.Estado_Civil;

                    CEPTextBox.Text = endereco.CEP;
                    LogradouroTextBox.Text = endereco.Logradouro;
                    NumeroTextBox.Text = endereco.Numero;
                    ComplementoTextBox.Text = endereco.Complemento;
                    BairroTextBox.Text = endereco.Bairro;
                    CidadeTextBox.Text = endereco.Cidade;
                    UFEnderecoTextBox.Text = endereco.UF;


                }
            }
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

            clienteService.Put(cliente);
            clienteEnderecoService.Put(clienteEndereco);

            Response.Redirect("~/CadCliente/Index");
        }

    }
}
