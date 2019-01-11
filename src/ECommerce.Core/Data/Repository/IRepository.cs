using ECommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Core.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        Task<TEntity> GetByIdAsync(int id);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();
        Task UpdateAsync(TEntity entity);
        Task InsertAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);


        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);
    }
}
