using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
