using System.Collections.Generic;
using System.Threading.Tasks;
using setours.jarvis.domain.entity;
using setours.jarvis.domain.interfaces;
using setours.jarvis.infrastructure.interfaces;
using setours.jarvis.transversal.common.Bases.Querys;

namespace setours.jarvis.domain.core
{
    public abstract class BaseDomain<TRepository, TEntity> : IBaseDomain<TEntity>
        where TEntity : class, IEntity
        where TRepository : IBaseRepository<TEntity>
    {
        protected readonly TRepository _repository;

        public BaseDomain(TRepository repository)
        {
            _repository = repository;
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public Task<IEnumerable<TEntity>> GetSearchAsync(BaseSearchQuery search)
        {
            return _repository.GetSearchAsync(search);
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            return _repository.InsertAsync(entity);
        }

        public Task<IEnumerable<TEntity>> InsertBulkAsync(IEnumerable<TEntity> entities)
        {
            return _repository.InsertBulkAsync(entities);
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public Task<IEnumerable<TEntity>> UpdateBulkAsync(IEnumerable<TEntity> entities)
        {
            return _repository.UpdateBulkAsync(entities);
        }

        public Task<TEntity> DeleteAsync(TEntity entity)
        {
            return _repository.DeleteAsync(entity);
        }

        public Task<IEnumerable<TEntity>> DeleteBulkAsync(IEnumerable<TEntity> entities)
        {
            return _repository.DeleteBulkAsync(entities);
        }
    }
}
