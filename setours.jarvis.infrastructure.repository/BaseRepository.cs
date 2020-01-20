using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using setours.jarvis.domain.entity;
using setours.jarvis.infrastructure.interfaces;
using setours.jarvis.infrastructure.persistence;
using setours.jarvis.transversal.common.Bases.Querys;

namespace setours.jarvis.infrastructure.repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        protected readonly DbContext _context;

        private readonly DbSet<TEntity> _dbset;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbset.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetSearchAsync(BaseSearchQuery search)
        {
            var query = _dbset
                .IncludeJoins(search.Includes)
                .Filter(search.Filters)
                .Sort(search.Sort)
                .Paginate(search.Page, search.Size);

            _ = query.ToSql();

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> InsertBulkAsync(IEnumerable<TEntity> entities)
        {
            await _dbset.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return entities;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbset.Update(await _context.Set<TEntity>().FindAsync(entity));
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> UpdateBulkAsync(IEnumerable<TEntity> entities)
        {
            _dbset.UpdateRange(await _context.Set<TEntity>().FindAsync(entities));
            await _context.SaveChangesAsync();
            return entities;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            _dbset.Remove(await _context.Set<TEntity>().FindAsync(entity));
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> DeleteBulkAsync(IEnumerable<TEntity> entities)
        {
            _dbset.RemoveRange(entities);
            await _context.SaveChangesAsync();
            return entities;
        }
    }
}
