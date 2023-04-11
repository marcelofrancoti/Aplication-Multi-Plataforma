using Dapper;
using Data.Dapper;
using Entity;
using System.Collections.Generic;

namespace Data
{
    public class ClienteEnderecoData : IDataAdmin<ClienteEndereco>
    {
        private readonly Acesso _acessoDataDapper;

        public ClienteEnderecoData()
        {
            _acessoDataDapper = new Acesso();
        }

        public void Atualizar(ClienteEndereco a)
        {
            _acessoDataDapper.dbConnectiondbConnection.Execute(@"
            UPDATE [dbo].[EnderecoCliente]
            SET [ClienteId] = @ClienteId,
                [CEP] = @CEP,
                [Logradouro] = @Logradouro,
                [Numero] = @Numero,
                [Complemento] = @Complemento,
                [Bairro] = @Bairro,
                [Cidade] = @Cidade,
                [UF] = @UF
            WHERE EnderecoId = @EnderecoId", a);
        }

        public ClienteEndereco BuscarPorId(int ClienteId)
        {
            return _acessoDataDapper.dbConnectiondbConnection.QueryFirstOrDefault<ClienteEndereco>(@"
            SELECT [EnderecoId],
                   [ClienteId],
                   [CEP],
                   [Logradouro],
                   [Numero],
                   [Complemento],
                   [Bairro],
                   [Cidade],
                   [UF]
            FROM [dbo].[EnderecoCliente]
            WHERE ClienteId = @ClienteId", new { ClienteId });
        }

        public IEnumerable<ClienteEndereco> BuscarTodos()
        {
            return _acessoDataDapper.dbConnectiondbConnection.Query<ClienteEndereco>(@"
            SELECT [EnderecoId],
                   [ClienteId],
                   [CEP],
                   [Logradouro],
                   [Numero],
                   [Complemento],
                   [Bairro],
                   [Cidade],
                   [UF]
            FROM [dbo].[EnderecoCliente]");
        }

        public void Excluir(int EnderecoId)
        {
            _acessoDataDapper.dbConnectiondbConnection.Execute(@"
            DELETE FROM [dbo].[EnderecoCliente] WHERE EnderecoId = @EnderecoId", new { EnderecoId });
        }

        public void Inserir(ClienteEndereco a)
        {
            _acessoDataDapper.dbConnectiondbConnection.ExecuteScalar<ClienteEndereco>(@"
            INSERT INTO [dbo].[EnderecoCliente]
                ([ClienteId],
                 [CEP],
                 [Logradouro],
                 [Numero],
                 [Complemento],
                 [Bairro],
                 [Cidade],
                 [UF])
            VALUES
                (@ClienteId,
                 @CEP,
                 @Logradouro,
                 @Numero,
                 @Complemento,
                 @Bairro,
                 @Cidade,
                 @UF)", a);
        }
    }
}
