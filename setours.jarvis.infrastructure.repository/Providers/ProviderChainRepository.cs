using setours.jarvis.domain.entity.Providers;
using setours.jarvis.infrastructure.interfaces.Providers;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Providers
{
    public class ProviderChainRepository : BaseRepository<ProviderChainEntity>, IProviderChainRepository
    {
        public ProviderChainRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
