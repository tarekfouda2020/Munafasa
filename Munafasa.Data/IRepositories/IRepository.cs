using System;
using System.Linq.Expressions;

namespace Munafasa.Data.IRepositories
{
    public interface IRepository<T> where T : class
    {
        T? GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);

        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);

        void Add(T entity);

        void Remove(T entity);

        void RemoveRang(IEnumerable<T> entities);

    }
}

