using ECommerce.Core.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Core.Data.Repository
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task<T> AddAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<T> UpdateAsyn(T t);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate=null);
        Task<int> SaveAsync();
    }
}
