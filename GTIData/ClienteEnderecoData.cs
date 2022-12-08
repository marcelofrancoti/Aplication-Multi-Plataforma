using Dapper;
using Data.Dapper;
using GTIEntity;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace GTIData
{
    public class ClienteEnderecoData : IDataAdmin<ClienteEndereco>
    {
        Acesso _acessoDataDapper = new Acesso();
        public void Atualizar(ClienteEndereco a)
        {
            _acessoDataDapper.dbConnectiondbConnection.Execute(@"
                    UPDATE [dbo].[EnderecoCliente]
                       SET [ClienteId] = @ClienteId
                          ,[CEP] = @CEP
                          ,[Logradouro] = @Logradouro
                          ,[Numero] = @Numero
                          ,[Complemento] = @Complemento
                          ,[Bairro] = @Bairro
                          ,[Cidade] = @Cidade
                          ,[UF] = @UF
                        WHERE EnderecoId = @EnderecoId", new {
                                    a.EnderecoId,
                                    a.ClienteId,
                                    a.CEP,
                                    a.Logradouro,
                                    a.Numero,
                                    a.Complemento,
                                    a.Bairro,
                                    a.Cidade,
                                    a.UF
            });
        }

        public ClienteEndereco BuscarPorId(int ClienteId)
        {
            return _acessoDataDapper.dbConnectiondbConnection.Query<ClienteEndereco>(@"
                         SELECT [EnderecoId]
                              ,[ClienteId]
                              ,[CEP]
                              ,[Logradouro]
                              ,[Numero]
                              ,[Complemento]
                              ,[Bairro]
                              ,[Cidade]
                              ,[UF]
                          FROM [dbo].[EnderecoCliente]
                WHERE ClienteId = @ClienteId", new { ClienteId }).FirstOrDefault();
        }

        public IEnumerable<ClienteEndereco> BuscarTodos()
        {
            return _acessoDataDapper.dbConnectiondbConnection.Query<ClienteEndereco>(@"
                        SELECT [EnderecoId]
                              ,[ClienteId]
                              ,[CEP]
                              ,[Logradouro]
                              ,[Numero]
                              ,[Complemento]
                              ,[Bairro]
                              ,[Cidade]
                              ,[UF]
                          FROM [dbo].[EnderecoCliente]");
        }

        public void Excluir(int EnderecoId)
        {
            _acessoDataDapper.dbConnectiondbConnection.Execute(@"
                                DELETE FROM [dbo].[EnderecoCliente] where EnderecoId = @EnderecoId ", new { EnderecoId });
        }

        public void Inserir(ClienteEndereco a)
        {
            _acessoDataDapper.dbConnectiondbConnection.ExecuteScalar<ClienteEndereco>(@"
                       INSERT INTO [dbo].[EnderecoCliente]
                               ([ClienteId]
                               ,[CEP]
                               ,[Logradouro]
                               ,[Numero]
                               ,[Complemento]
                               ,[Bairro]
                               ,[Cidade]
                               ,[UF])
                         VALUES
                            (   @ClienteId
                               , @CEP
                               , @Logradouro
                               , @Numero
                               , @Complemento
                               , @Bairro
                               , @Cidade
                               , @UF)
                                ", new
            {
                a.ClienteId,
                a.CEP,
                a.Logradouro,
                a.Numero,
                a.Complemento
                                ,
                a.Bairro,
                a.Cidade,
                a.UF
            });
        }
    }
}
