using System;


namespace WebForm
{
    public partial class Alterar : System.Web.UI.Page
    {
        public int clienteId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (int.TryParse(Request.QueryString["ClienteId"], out clienteId))
                {
                    ServiceReferencesCliente.ClienteService clienteService = new ServiceReferencesCliente.ClienteService();
                    ServiceReferencesClienteEndereco.ClienteEnderecoService clienteEnderecoService = new ServiceReferencesClienteEndereco.ClienteEnderecoService();

                    var endereco = clienteEnderecoService.GetPorId(clienteId, true);
                    var cliente = clienteService.GetPorId(clienteId, true);


                    if (cliente != null)
                    {
                        ClienteIdTextBox.Text = cliente.ClienteId.ToString();
                        NomeTextBox.Text = cliente.Nome;
                        CPFTextBox.Text = cliente.CPF;
                        RGTextBox.Text = cliente.RG;
                        DataExpedicaoTextBox.Text = cliente.Data_Expedicao;
                        OrgaoExpedicaoTextBox.Text = cliente.Orgao_Expedicao;
                        UFTextBox.Text = cliente.UF;
                        DataNascimentoTextBox.Text = cliente.Data_de_Nascimento;
                        SexoDropDownList.SelectedValue = cliente.Sexo;
                        EstadoCivilDropDownList.SelectedValue = cliente.Estado_Civil;
                    }



                    if (endereco != null)
                    {
                        ClienteEnderecoIdTextBox.Text = endereco.ClienteId.ToString();
                        EnderecoIdTextBox.Text = endereco.EnderecoId.ToString();
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
        }


        protected void VoltarButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pages/Visualizar");
        }

        protected void SalvarButton_Click(object sender, EventArgs e)
        {

        }

        protected void alterarCliente_Click(object sender, EventArgs e)
        {
            clienteId = int.Parse(Request.QueryString["ClienteId"]);
            ServiceReferencesCliente.ClienteService clienteService = new ServiceReferencesCliente.ClienteService();
            ServiceReferencesClienteEndereco.ClienteEnderecoService clienteEnderecoService = new ServiceReferencesClienteEndereco.ClienteEnderecoService();

            ServiceReferencesCliente.Cliente cliente = new ServiceReferencesCliente.Cliente();
            ServiceReferencesClienteEndereco.ClienteEndereco clienteEndereco = new ServiceReferencesClienteEndereco.ClienteEndereco();

            cliente.ClienteIdSpecified = true;
            cliente.ClienteId = int.Parse(ClienteIdTextBox.Text);
            cliente.Nome = NomeTextBox.Text;
            cliente.CPF = CPFTextBox.Text;
            cliente.RG = RGTextBox.Text;
            cliente.Data_Expedicao = DataExpedicaoTextBox.Text;
            cliente.Orgao_Expedicao = OrgaoExpedicaoTextBox.Text;
            cliente.UF = UFTextBox.Text;
            cliente.Data_de_Nascimento = DataNascimentoTextBox.Text;
            cliente.Sexo = SexoDropDownList.SelectedValue;
            cliente.Estado_Civil = EstadoCivilDropDownList.SelectedValue;

            clienteService.Put(cliente);

            clienteEndereco.ClienteIdSpecified = true;
            clienteEndereco.ClienteId = int.Parse(ClienteIdTextBox.Text);
            clienteEndereco.CEP = CEPTextBox.Text;
            clienteEndereco.Logradouro = LogradouroTextBox.Text;
            clienteEndereco.Numero = NumeroTextBox.Text;
            clienteEndereco.Complemento = ComplementoTextBox.Text;
            clienteEndereco.Bairro = BairroTextBox.Text;
            clienteEndereco.Cidade = CidadeTextBox.Text;
            clienteEndereco.UF = UFEnderecoTextBox.Text;

            if (!string.IsNullOrEmpty(EnderecoIdTextBox.Text))
            {
                clienteEndereco.EnderecoId = int.Parse(EnderecoIdTextBox.Text);
                clienteEnderecoService.Put(clienteEndereco);
            }
            else
            {
                clienteEnderecoService.Post(clienteEndereco);
            }

            Response.Redirect("~/pages/Visualizar");
        }
    }
}
