using Microsoft.EntityFrameworkCore;
using setours.jarvis.domain.entity.Providers;
using setours.jarvis.infrastructure.interfaces.Providers;
using setours.jarvis.infrastructure.persistence;
using setours.jarvis.transversal.common.Bases.Querys;
using System.Collections.Generic;   
using System.Threading.Tasks;

namespace setours.jarvis.infrastructure.repository.Providers
{
    public class ProviderRepository : BaseRepository<ProviderEntity>, IProviderRepository
    {
        public ProviderRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<ProviderEntity>> GetSearch2(BaseSearchQuery search)
        {
            var query = _context.Set<ProviderEntity>()
                    .IncludeJoins(search.Includes)
                    .Filter(search.Filters)
                    .Sort(search.Sort)
                    .Paginate(search.Page, search.Size);

            _ = query.ToSql();

            return await query.AsNoTracking().ToListAsync();
        }
    }
}
