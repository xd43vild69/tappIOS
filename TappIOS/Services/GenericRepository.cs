using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TappIOS.Domain;

namespace TappIOS.Services
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> Query();
        Task<TEntity> GetByIdOrDefault(Guid id, bool withTracking = true, CancellationToken cancellationToken = default);
        Task<TEntity> GetById(Guid id, bool withTracking = true, CancellationToken cancellationToken = default);
        Task<bool> Exists(Guid id, CancellationToken cancellationToken = default);
        Task Add(TEntity entity, CancellationToken cancellationToken = default);
        Task AddRange(IEnumerable<TEntity> entity, CancellationToken cancellationToken = default);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entity);
        //Task<List<TEntity>> ListAsync(ISpecification<TEntity> specification, CancellationToken cancellationToken = default);
        //Task<List<TResult>> ListAsync<TResult>(ISpecification<TEntity, TResult> specification, CancellationToken cancellationToken = default);
        //Task<TEntity?> GetByIdOrDefault(ISpecification<TEntity> specification, CancellationToken cancellationToken = default);
        //Task<TResult?> GetByIdOrDefault<TResult>(ISpecification<TEntity, TResult> specification, CancellationToken cancellationToken = default);
        //Task<TEntity> GetById(ISpecification<TEntity> specification, CancellationToken cancellationToken = default);
        //Task<TResult> GetById<TResult>(ISpecification<TEntity, TResult> specification, CancellationToken cancellationToken = default);
    }

    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        public Task Add(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task AddRange(IEnumerable<TEntity> entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntity> GetById(Guid id, bool withTracking = true, CancellationToken cancellationToken = default)
        {
            var entity = await GetByIdOrDefault(id, withTracking, cancellationToken);

            if (entity == null)
                throw new Exception($"{typeof(TEntity).Name} with an id '{id}' was not found.");

            return entity;
        }

        public Task<TEntity> GetByIdOrDefault(Guid id, bool withTracking = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

