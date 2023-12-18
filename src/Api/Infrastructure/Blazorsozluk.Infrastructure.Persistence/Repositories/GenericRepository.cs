﻿using Blazorsozluk.Api.Models;
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

        public Task<int> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Add(TEntity entity)
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

        public Task<int> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public int Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRange(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRangeAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddOrUpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int AddOrUpdate(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> AsQueryable()
        {
            throw new NotImplementedException();
        }

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