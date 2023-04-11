using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Data.nHibernate
{
    public class ProdutoMap : ClassMapping<Produto>
    {
        public ProdutoMap()
        {
            Table("Produtos"); // Nome da tabela no banco de dados
            Id(x => x.Id, m => m.Generator(Generators.Identity)); // Configuração do ID
            Property(x => x.Nome); // Configuração da propriedade Nome
            Property(x => x.Preco); // Configuração da propriedade Preco
        }
    }
}
