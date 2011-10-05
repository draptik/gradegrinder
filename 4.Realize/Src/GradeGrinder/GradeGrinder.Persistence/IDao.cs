using System;

namespace GradeGrinder.Persistence
{
    public interface IDao<TEntity>
    {
        TEntity Get(Guid id);
        void Save(TEntity entity);
        //T Save(T entity);
        //T FindUnique(IdT id, bool shouldLock);
        //IList<T> Find();
        //void Delete(T entity);

        //IList<T> FindByExample(T exampleInstance, params string[] propertiesToExclude);
        //T FindUniqueByExample(T exampleInstance, params string[] propertiesToExclude);
        //T SaveOrUpdate(T entity);
        //void CommitChanges();
    }
}
