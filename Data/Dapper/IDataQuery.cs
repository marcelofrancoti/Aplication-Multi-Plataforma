using System.Collections.Generic;

namespace Data.Dapper
{
    public interface IDataQuery<T>
    {
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(int Id);
    }
}
