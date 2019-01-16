using ECommerce.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Core.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        public Repository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException("DbContext can not be null.");
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IQueryable<TEntity>> AllAsync()
        {
            return await Task.FromResult(_dbSet);
        }

        public virtual async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            if (entity==null)
            {
                throw new NullReferenceException($"{nameof(entity)} was not found!");
            }
            if (entity.GetType().GetProperty("IsDelete")!=null)
            {
                entity
                    .GetType()
                    .GetProperty("IsDelete")
                    .SetValue(entity, true);
                await UpdateAsync(entity);
            }
        }

        public virtual async Task DeleteAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = await FirstOrDefaultAsync(predicate);
            await DeleteAsync(entity);
        }

        public virtual  Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return this._dbSet.FirstOrDefaultAsync(predicate);
        }

        public virtual async Task SaveAsync(TEntity entity)
        {
            if (entity==null)
            {
                throw new NullReferenceException($"{nameof(entity)} was not found");
            }
            var item = await this._context.AddAsync<TEntity>(entity);
            item.State = EntityState.Added;
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            if (entity==null)
            {
                throw new NullReferenceException($"{nameof(entity)}was not found!");
            }
            await Task.Run(() =>
            {
                this._context.Attach<TEntity>(entity);
                var item = this._context.Entry<TEntity>(entity);
                item.State = EntityState.Modified;
            });
        }

        public virtual async Task<IQueryable<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.FromResult(_dbSet.Where(predicate));
        }
    }
}
