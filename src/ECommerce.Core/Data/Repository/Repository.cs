using ECommerce.Core.Data.Context;
using ECommerce.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Core.Data.Repository
{
    public class Repository<TEntity, TDbContext> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TDbContext : DbContext, IDbContext, new()
    {
        protected readonly TDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        public Repository(TDbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("DbContext can not be null.");

            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<TEntity>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
