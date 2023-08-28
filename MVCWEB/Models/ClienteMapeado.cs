using Entity;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MVCWEB.Models
{
    public static class ClienteMapeado
    {
        public static CadastroClienteViewModel ToViewModel(this Cliente cliente)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));

            return new CadastroClienteViewModel
            {
                ClienteId = cliente.ClienteId,
                CPF = cliente.CPF,
                Nome = cliente.Nome,
                RG = cliente.RG,
                Data_Expedicao = cliente.Data_Expedicao,
                Orgao_Expedicao = cliente.Orgao_Expedicao,
                UF = cliente.UF,
                Data_de_Nascimento = cliente.Data_de_Nascimento,
                Sexo = cliente.Sexo,
                Estado_Civil = cliente.Estado_Civil
            };
        }

        public static Cliente ToEntity(this CadastroClienteViewModel viewModel)
        {
            if (viewModel == null) throw new ArgumentNullException(nameof(viewModel));

            return new Cliente
            {
                ClienteId = viewModel.ClienteId,
                CPF = viewModel.CPF,
                Nome = viewModel.Nome,
                RG = viewModel.RG,
                Data_Expedicao = viewModel.Data_Expedicao,
                Orgao_Expedicao = viewModel.Orgao_Expedicao,
                UF = viewModel.UF,
                Data_de_Nascimento = viewModel.Data_de_Nascimento,
                Sexo = viewModel.Sexo,
                Estado_Civil = viewModel.Estado_Civil
            };
        }

    }
}