using setours.jarvis.domain.entity.Providers;
using setours.jarvis.domain.interfaces.Providers;
using setours.jarvis.infrastructure.interfaces.Providers;
using setours.jarvis.transversal.common.Bases.Querys;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace setours.jarvis.domain.core.Providers
{
    public class ProviderDomain : BaseDomain<IProviderRepository, ProviderEntity>, IProviderDomain
    {
        public ProviderDomain(IProviderRepository repository) : base(repository)
        {

        }

        public async Task<IEnumerable<ProviderEntity>> GetSearch2(BaseSearchQuery search)
        {
            return await _repository.GetSearch2(search);
        }
    }
}
