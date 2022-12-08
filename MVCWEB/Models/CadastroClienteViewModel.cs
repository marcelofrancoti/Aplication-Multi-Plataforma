using GTIEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWEB.Models
{
    public class CadastroClienteViewModel
    {
        public int ClienteId { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string Data_Expedicao { get; set; }
        public string Orgao_Expedicao { get; set; }
        public string UF { get; set; }
        public string Data_de_Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Estado_Civil { get; set; }

        public IEnumerable<ClienteEndereco> listaEndere { get; set; }

        public static implicit operator CadastroClienteViewModel(Cliente v)
        {
            return new CadastroClienteViewModel()
            {

                ClienteId = v.ClienteId,
                CPF = v.CPF,
                Nome = v.Nome,
                RG = v.RG,
                Data_Expedicao = v.Data_Expedicao,
                Orgao_Expedicao = v.Orgao_Expedicao,
                UF = v.UF,
                Data_de_Nascimento = v.Data_de_Nascimento,
                Sexo = v.Sexo,
                Estado_Civil = v.Estado_Civil,
            };
        }
    }
}