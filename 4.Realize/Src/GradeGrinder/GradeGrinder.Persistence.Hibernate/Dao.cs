using System;
using NHibernate;

namespace GradeGrinder.Persistence.Hibernate
{
    public class Dao<TEntity> : IDao<TEntity>
    {
        private readonly ISessionFactory _sessionFactory;

        public Dao(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        protected ISession Session { get { return _sessionFactory.GetCurrentSession(); } }

        #region Implementation of IDao<TEntity>

        public TEntity Get(Guid id)
        {
            return Session.Get<TEntity>(id);
        }

        public void Save(TEntity entity)
        {
            Session.SaveOrUpdate(entity);
        }

        #endregion
    }
}
