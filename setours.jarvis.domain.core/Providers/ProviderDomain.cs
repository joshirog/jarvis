using setours.jarvis.domain.entity.Providers;
using setours.jarvis.domain.interfaces.Providers;
using setours.jarvis.infrastructure.interfaces.Providers;

namespace setours.jarvis.domain.core.Providers
{
    public class ProviderDomain : BaseDomain<IProviderRepository, ProviderEntity>, IProviderDomain
    {
        public ProviderDomain(IProviderRepository repository) : base(repository)
        {

        }
    }
}
