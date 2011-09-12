using System.Collections.Generic;

namespace GradeGrinder.Persistence
{
    public interface IDao<T, IdT>
    {
        T Save(T entity);
        T FindUnique(IdT id, bool shouldLock);
        IList<T> Find();
        void Delete(T entity);

        IList<T> FindByExample(T exampleInstance, params string[] propertiesToExclude);
        T FindUniqueByExample(T exampleInstance, params string[] propertiesToExclude);
        T SaveOrUpdate(T entity);
        void CommitChanges();
    }
}
