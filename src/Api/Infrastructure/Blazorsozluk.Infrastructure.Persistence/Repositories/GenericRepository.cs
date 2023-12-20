using Blazorsozluk.Api.Models;
using Blazorsozluk.Infrastructure.Persistence.Context;
using BlazorSozluk.Api.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blazorsozluk.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<TEntity>:IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly BlazorSozlukContext dbContext;
        protected DbSet<TEntity> entity => dbContext.Set<TEntity>();


        public GenericRepository(BlazorSozlukContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

        }

        #region Insert Methods
        public virtual async Task<int> AddAsync(TEntity entity)
        {
            await this.entity.AddAsync(entity);
            return await dbContext.SaveChangesAsync();
        }

        public virtual int Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Add(Task<int> entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Update methods
        public virtual async Task<int> UpdateAsync(TEntity entity)
        {
            this.entity.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
            return await dbContext.SaveChangesAsync();

        }

        public virtual int Update(TEntity entity)
        {
            this.entity.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
            return dbContext.SaveChanges();
        }
        #endregion
        #region Delete METHODS
        public virtual async Task<int> DeleteAsync(TEntity entity)
        {
            if (dbContext.Entry(entity).State==EntityState.Detached)
            {
                this.entity.Attach(entity);
            }
            this.entity.Remove(entity);
            return await dbContext.SaveChangesAsync();
        }

        public virtual int Delete(TEntity entity)
        {
            if (dbContext.Entry(entity).State == EntityState.Detached)
            {
                this.entity.Attach(entity);
            }
            this.entity.Remove(entity);
            return  dbContext.SaveChanges();
        }

        public virtual Task<int> DeleteAsync(Guid id)
        {
            var entity = this.entity.Find(id);
            return DeleteAsync(entity);
        }

        public virtual int Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual bool DeleteRange(Expression<Func<TEntity, bool>> predicate)
        {
            dbContext.RemoveRange(predicate);
            return dbContext.SaveChanges() > 0;
        }

        public virtual async Task<bool> DeleteRangeAsync(Expression<Func<TEntity, bool>> predicate)
        {
            dbContext.RemoveRange(predicate);
            return await dbContext.SaveChangesAsync() > 0;
        }
        #endregion
        #region AddOrUpdate Methods
        public virtual Task<int> AddOrUpdateAsync(TEntity entity)
        {
            if (!this.entity.Local.Any(i => EqualityComparer<Guid>.Default.Equals(i.Id, entity.Id)))
                dbContext.Update(entity);
            return dbContext.SaveChangesAsync();
        }

        public virtual int AddOrUpdate(TEntity entity)
        {
            if (!this.entity.Local.Any(i => EqualityComparer<Guid>.Default.Equals(i.Id, entity.Id)))
                dbContext.Update(entity);
            return dbContext.SaveChanges();
        }

        public IQueryable<TEntity> AsQueryable()
        {
            throw new NotImplementedException();
        }
        #endregion

        public Task<List<TEntity>> GetAll(bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> predicate, bool noTracking = true, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsyn(Guid id, bool noTracking = true, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate, bool noTracking = true, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool noTracking = true, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, bool noTracking = true, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task BulkDeleteById(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Task BulkDelete(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task BulkDelete(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task BulkUpdate(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task BulkAdd(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
