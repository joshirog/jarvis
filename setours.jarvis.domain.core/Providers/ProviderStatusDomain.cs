using setours.jarvis.domain.entity.Providers;
using setours.jarvis.domain.interfaces.Providers;
using setours.jarvis.infrastructure.interfaces.Providers;

namespace setours.jarvis.domain.core.Providers
{
    public class ProviderStatusDomain : BaseDomain<IProviderStatusRepository, ProviderStatusEntity>, IProviderStatusDomain
    {
        public ProviderStatusDomain(IProviderStatusRepository repository) : base(repository)
        {

        }
    }
}
