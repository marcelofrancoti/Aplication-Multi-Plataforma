using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dapper
{
    public interface IDataCommand<T>
    {

        void Excluir(int id);
        void Atualizar(T a);
        void Inserir(T a);
    }
}
