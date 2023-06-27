using System;
using System.Linq.Expressions;

namespace Munafasa.Data.IRepositories
{
    public interface IRepository<T> where T : class
    {
        T? GetFirstOrDefault(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[]? includes);

        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? includes);


        void Add(T entity);

        void Remove(T entity);

        void RemoveRang(IEnumerable<T> entities);

    }
}

