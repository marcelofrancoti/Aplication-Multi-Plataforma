using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Dapper
{
    public  class Acesso
    {
        private IDbConnection _connection;
        public Acesso()
        {
            _connection = new SqlConnection("Data Source=MARCELODEV;Initial Catalog=BancoDados;Integrated Security=True;TrustServerCertificate=True;");
        }

        public IDbConnection dbConnectiondbConnection => _connection;
    }
}
