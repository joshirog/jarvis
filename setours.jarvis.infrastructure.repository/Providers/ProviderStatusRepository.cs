using setours.jarvis.domain.entity.Providers;
using setours.jarvis.infrastructure.interfaces.Providers;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Providers
{
    public class ProviderStatusRepository : BaseRepository<ProviderStatusEntity>, IProviderStatusRepository
    {
        public ProviderStatusRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
