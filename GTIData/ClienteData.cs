using Dapper;
using Data.Dapper;
using GTIEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GTIData
{
    public class ClienteData : IDataAdmin<Cliente>
    {
        Acesso _acessoDataDapper = new Acesso();
        public void Atualizar(Cliente cliente)
        {
            _acessoDataDapper.dbConnectiondbConnection.Execute(@"
                   UPDATE Cliente SET [CPF] = @CPF
                      ,[Nome] = @Nome
                      ,[RG] = @RG
                      ,[Data_Expedicao] = @Data_Expedicao
                      ,[Orgao_Expedicao] = @Orgao_Expedicao
                      ,[UF] = @UF
                      ,[Data_de_Nascimento] = @Data_de_Nascimento
                      ,[Sexo] = @Sexo
                      ,[Estado_Civil] = @Estado_Civil
                      WHERE ClienteId = @ClienteId", new{
                                                    cliente.CPF,
                                                    cliente.ClienteId,
                                                    cliente.Nome,
                                                    cliente.RG,
                                                    cliente.Data_Expedicao,
                                                    cliente.Orgao_Expedicao,
                                                    cliente.UF,
                                                    cliente.Data_de_Nascimento,
                                                    cliente.Sexo,
                                                    cliente.Estado_Civil,
                                                    });
        }

        public Cliente BuscarPorId(int ClienteId)
        {
            return _acessoDataDapper.dbConnectiondbConnection.Query<Cliente>(@"
                        SELECT [ClienteId]
                                  ,[CPF]
                                  ,[Nome]
                                  ,[RG]
                                  ,[Data_Expedicao]
                                  ,[Orgao_Expedicao]
                                  ,[UF]
                                  ,[Data_de_Nascimento]
                                  ,[Sexo]
                                  ,[Estado_Civil]
                              FROM [dbo].[Cliente]
                        WHERE ClienteId = @ClienteId", new { ClienteId }).FirstOrDefault();
        }

        public IEnumerable<Cliente> BuscarTodos()
        {
            return _acessoDataDapper.dbConnectiondbConnection.Query<Cliente>(@"
                        SELECT [ClienteId]
                              ,[CPF]
                              ,[Nome]
                              ,[RG]
                              ,[Data_Expedicao]
                              ,[Orgao_Expedicao]
                              ,[UF]
                              ,[Data_de_Nascimento]
                              ,[Sexo]
                              ,[Estado_Civil]
                          FROM [dbo].[Cliente]");
        }

        public void Excluir(int ClienteId)
        {
            _acessoDataDapper.dbConnectiondbConnection.Execute(@"
                                DELETE FROM [dbo].[Cliente]
                                WHERE ClienteId = @ClienteId", new { ClienteId });
        }

        public void Inserir(Cliente a)
        {
            _acessoDataDapper.dbConnectiondbConnection.ExecuteScalar<Cliente>(@"
                        INSERT INTO [dbo].[Cliente]
                               ([CPF]
                               ,[Nome]
                               ,[RG]
                               ,[Data_Expedicao]
                               ,[Orgao_Expedicao]
                               ,[UF]
                               ,[Data_de_Nascimento]
                               ,[Sexo]
                               ,[Estado_Civil])
                         VALUES
                               (@CPF
                               ,@Nome
                               ,@RG
                               ,@Data_Expedicao
                               ,@Orgao_Expedicao
                               ,@UF
                               ,@Data_de_Nascimento
                               ,@Sexo
                               ,@Estado_Civil)", new { a.CPF, a.Nome, a.RG, a.Data_Expedicao,
                               a.Orgao_Expedicao, a.UF,a.Data_de_Nascimento, a.Sexo, a.Estado_Civil     });
        }
    }
}
