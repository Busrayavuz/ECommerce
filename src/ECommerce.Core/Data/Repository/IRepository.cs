using ECommerce.Core.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Core.Data.Repository
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        //struct ve reference type araştırılacak!!!!!!!
        Task<T> AddAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<IQueryable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<int> SaveAsync();
    }
}
