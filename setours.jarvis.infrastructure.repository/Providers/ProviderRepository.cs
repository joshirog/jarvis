using setours.jarvis.domain.entity.Providers;
using setours.jarvis.infrastructure.interfaces.Providers;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Providers
{
    public class ProviderRepository : BaseRepository<ProviderEntity>, IProviderRepository
    {
        public ProviderRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
