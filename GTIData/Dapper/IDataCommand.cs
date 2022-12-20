namespace Data.Dapper
{
    public interface IDataCommand<T>
    {

        void Excluir(int id);
        void Atualizar(T a);
        void Inserir(T a);
    }
}
