using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebForm.ServiceReferencesClienteEndereco;

namespace WebForm
{
    public class ClienteCompleto
    {
        public int    ClienteId         { get; set; }
        public string CPF              { get; set; }
        public string Nome             { get; set; }
        public string RG                { get; set; }
        public string Data_Expedicao    { get; set; }
        public string Orgao_Expedicao     { get; set; }
        public string UF                 { get; set; }
        public string Data_de_Nascimento { get; set; }
        public string Sexo                  { get; set; }
        public string Estado_Civil          { get; set; }

        public List<ClienteEndereco> ClienteEndereco { get; set; }

        public IEnumerable<ClienteEndereco> listaEndere { get; set; }


    }
}
