namespace Data.nHibernate
{
    public class DaoFactory
    {
        public static NHibernateDao<T> CreateDao<T>() where T : class
        {
            return new NHibernateDao<T>();
        }
    }
}
