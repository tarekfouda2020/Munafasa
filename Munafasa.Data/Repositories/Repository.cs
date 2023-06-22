using System;
using Microsoft.EntityFrameworkCore;
using Munafasa.Data.IRepositories;
using System.Linq;
using System.Linq.Expressions;

namespace Munafasa.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> _dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }

        void IRepository<T>.Add(T entity)
        {
            _dbSet.Add(entity);
        }

        IEnumerable<T> IRepository<T>.GetAll(Expression<Func<T, bool>>? filter, string? includeProperties)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var prop in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query.Include(prop);
                }
            }
            return query.ToList();
        }

        T? IRepository<T>.GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties)
        {
            IQueryable<T> query = _dbSet;
            query = query.Where(filter);
            if (includeProperties != null)
            {
                foreach (var prop in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query.Include(prop);
                }
            }
            return query.FirstOrDefault();
        }

        void IRepository<T>.Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        void IRepository<T>.RemoveRang(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}

