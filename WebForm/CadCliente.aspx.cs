using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm.ServiceReferencesCliente;
using WebForm.ServiceReferencesClienteEndereco;
using static System.Net.WebRequestMethods;

namespace WebForm
{
    public partial class CadCliente : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            PopularGridCliente();
            PopularGridClienteEndereco();
        }

        private void PopularGridCliente()
        {
            ServiceReferencesCliente.ClienteService cliente = new ServiceReferencesCliente.ClienteService();
            gridCliente.DataSource = cliente.Get();
            gridCliente.DataBind(); ;
        }

        private void PopularGridClienteEndereco()
        {
            ServiceReferencesClienteEndereco.ClienteEnderecoService clienteEndereco = new ServiceReferencesClienteEndereco.ClienteEnderecoService();
            gridClienteEndereco.DataSource = clienteEndereco.Get();
            gridClienteEndereco.DataBind(); ;
        }

        protected void btnPesquisarCEP_Click(object sender, EventArgs e)
        {
            BuscarCep();
        }

        private void BuscarCep()
        {
            HttpClient cep = new HttpClient();
            var resposta = cep.GetAsync(@"https://viacep.com.br/ws/" + txtCEP.Text.Trim() + "/json/").Result;

            string responseContent = resposta.Content.ReadAsStringAsync().Result;

            if (!responseContent.Contains("Http 400"))
            {
                EnderecoLocal clienteEndereco = JsonConvert.DeserializeObject<EnderecoLocal>(responseContent);


                txtRua.Text = clienteEndereco.logradouro;
                txtCidade.Text = clienteEndereco.localidade;
                txtBairro.Text = clienteEndereco.bairro;
                txtCompleto.Text = clienteEndereco.complemento;
                ddlUFEnd.Text = clienteEndereco.uf;
            }


        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();
            int idClienteVerifica = int.Parse(hdIdSelecionado.Text);
            if (idClienteVerifica != null && idClienteVerifica == 0)
            {
                clienteService.Post(new ServiceReferencesCliente.Cliente()
                {
                    CPF = txtCPF.Text,
                    Data_de_Nascimento = DateTime.Parse(txtDataNascimento.Text).ToString("yyyy-MM-dd"),
                    Data_Expedicao = DateTime.Parse(txtData_Expedicao.Text).ToString("yyyy-MM-dd"),
                    Nome = txtNome.Text,
                    Sexo = ddlSexo.Text,
                    Estado_Civil = ddlEstadoCivil.Text,
                    Orgao_Expedicao = dllOrgao.Text,
                    UF = ddlUF.Text,
                    RG = txtRG.Text,
                });

                hdIdSelecionado.Text = string.Empty;
            }
            else
            {
                int idCliente = int.Parse(hdIdSelecionado.Text);

                var cliente = clienteService.GetPorId(idCliente, true);

                cliente = new Cliente()
                {
                    CPF = txtCPF.Text,
                    Data_de_Nascimento = DateTime.Parse(txtDataNascimento.Text).ToString("yyyy-MM-dd"),
                    Data_Expedicao = DateTime.Parse(txtData_Expedicao.Text).ToString("yyyy-MM-dd"),
                    Nome = txtNome.Text,
                    Sexo = ddlSexo.Text,
                    Estado_Civil = ddlEstadoCivil.Text,
                    Orgao_Expedicao = dllOrgao.Text,
                    UF = ddlUF.Text,
                    RG = txtRG.Text,
                    ClienteIdSpecified = true,
                    ClienteId = idCliente,
                };

                clienteService.Put(cliente);
                hdIdSelecionado.Text = string.Empty;
            }

            PopularGridCliente();

        }

        protected void gridCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            hdIdSelecionado.Text = string.Empty;

            hdIdSelecionado.Text = gridCliente.SelectedRow.Cells[2].Text;

            ServiceReferencesCliente.ClienteService cliente = new ServiceReferencesCliente.ClienteService();
            Cliente result = cliente.GetPorId(int.Parse(hdIdSelecionado.Text), true);

            txtCPF.Text = result.CPF;
            txtDataNascimento.Text = result.Data_de_Nascimento.ToString();
            txtData_Expedicao.Text = result.Data_Expedicao.ToString();
            txtNome.Text = result.Nome;
            ddlSexo.Text = result.Sexo;
            ddlUF.Text = result.UF;
            txtRG.Text = result.RG;


        }

        protected void gridClienteEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIDEndereco.Text = string.Empty;

            lblIDEndereco.Text = gridClienteEndereco.SelectedRow.Cells[1].Text;

            ClienteEnderecoService enderecoService = new ClienteEnderecoService();
            ClienteEndereco result = enderecoService.GetPorId(int.Parse(lblIDEndereco.Text), true);

            if (result != null)
            {
                txtCEP.Text = result.CEP;
                txtRua.Text = result.Logradouro;
                txtNumero.Text = result.Numero;
                txtCompleto.Text = result.Complemento;
                txtBairro.Text = result.Bairro;
                txtCidade.Text = result.Cidade;

            }



        }

        protected void btnAtualizarEndereco_Click(object sender, EventArgs e)
        {
            ClienteEnderecoService enderecoService = new ClienteEnderecoService();
            int idEnderecoVerifica = int.Parse(lblIDEndereco.Text);

            if (idEnderecoVerifica != null && idEnderecoVerifica == 0)
            {
                enderecoService.Post(new ClienteEndereco()
                {
                    CEP = txtCEP.Text,
                    Logradouro = txtRua.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtCompleto.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                });

                hdIdSelecionado.Text = string.Empty;
            }
            else
            {

                var idEndereco = int.Parse(lblIDEndereco.Text);
                var idCliente = enderecoService != null ? enderecoService.GetPorId(int.Parse(lblIDEndereco.Text), true).ClienteId : 0;
                var endereco = enderecoService.GetPorId(idEndereco, true);
                endereco = new ClienteEndereco()
                {
                    CEP = txtCEP.Text,
                    UF = txtRua.Text,
                    EnderecoIdSpecified = true,
                    EnderecoId = idEndereco,
                    ClienteIdSpecified = true,
                    ClienteId = idCliente,
                    Logradouro = txtRua.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtCompleto.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                };
                enderecoService.Put(endereco);
                lblIDEndereco.Text = string.Empty;
            }

            PopularGridClienteEndereco();
        }
    }
}