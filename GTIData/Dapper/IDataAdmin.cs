namespace Data.Dapper
{
    public interface IDataAdmin<T> : IDataCommand<T>, IDataQuery<T>
    {
    }
}
