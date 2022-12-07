using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dapper
{
    public interface IDataQuery<T>
    {
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(int Id);
    }
}
