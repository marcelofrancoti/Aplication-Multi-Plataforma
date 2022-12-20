using Data.Dapper;
using Entity;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IClienteBusiness : IDataAdmin<Cliente>
    {
        IEnumerable<Cliente> BuscarTodos();
    }
}
