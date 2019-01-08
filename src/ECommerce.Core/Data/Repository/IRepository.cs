using ECommerce.Core.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Core.Data.Repository
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task<IQueryable<T>> GetAllListAsync();
        IQueryable<T> GetAllList();
        IQueryable<T> GetAllList(Expression<Func<T, bool>> predicate);
        Task<IQueryable<T>> GetAllListAsync(Expression<Func<T, bool>> predicate);
        T Get(T entity);
        T Insert(T entity);
        Task<T> InsertAsync(T entity);
        T Update(T entity);
        Task<T> UpdateAsync(T entity);
        void Delete(T entity);
        Task DeleteAsync(T entity);
    }
}
