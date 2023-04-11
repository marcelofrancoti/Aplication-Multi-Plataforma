using System.Collections.Generic;
using NHibernate;

namespace Data.nHibernate
{
    public class NHibernateDao<T> where T : class
    {
        protected ISession Session => NHibernateConfig.SessionFactory.OpenSession();

        public T GetById(int id)
        {
            using (var session = Session)
            {
                return session.Get<T>(id);
            }
        }

        public IList<T> GetAll()
        {
            using (var session = Session)
            {
                return session.QueryOver<T>().List();
            }
        }

        public void Save(T entity)
        {
            using (var session = Session)
            using (var transaction = session.BeginTransaction())
            {
                session.Save(entity);
                transaction.Commit();
            }
        }

        public void Update(T entity)
        {
            using (var session = Session)
            using (var transaction = session.BeginTransaction())
            {
                session.Update(entity);
                transaction.Commit();
            }
        }

        public void Delete(T entity)
        {
            using (var session = Session)
            using (var transaction = session.BeginTransaction())
            {
                session.Delete(entity);
                transaction.Commit();
            }
        }
    }
}
