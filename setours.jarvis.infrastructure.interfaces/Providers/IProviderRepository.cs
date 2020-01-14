using setours.jarvis.domain.entity.Providers;
using setours.jarvis.transversal.common.Bases.Querys;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace setours.jarvis.infrastructure.interfaces.Providers
{
    public interface IProviderRepository : IBaseRepository<ProviderEntity>
    {
        Task<IEnumerable<ProviderEntity>> GetSearch2(BaseSearchQuery search);
    }
}
