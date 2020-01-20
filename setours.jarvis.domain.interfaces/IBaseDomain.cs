using System.Collections.Generic;
using System.Threading.Tasks;
using setours.jarvis.domain.entity;
using setours.jarvis.transversal.common.Bases.Querys;

namespace setours.jarvis.domain.interfaces
{
    public interface IBaseDomain<TEntity> where TEntity : class, IEntity
    {
        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> GetSearchAsync(BaseSearchQuery search);

        Task<TEntity> InsertAsync(TEntity entity);

        Task<IEnumerable<TEntity>> InsertBulkAsync(IEnumerable<TEntity> entities);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<IEnumerable<TEntity>> UpdateBulkAsync(IEnumerable<TEntity> entities);

        Task<TEntity> DeleteAsync(TEntity entity);

        Task<IEnumerable<TEntity>> DeleteBulkAsync(IEnumerable<TEntity> entities);
    }
}
