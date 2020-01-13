using setours.jarvis.domain.entity.Providers;
using setours.jarvis.domain.interfaces.Providers;
using setours.jarvis.infrastructure.interfaces.Providers;

namespace setours.jarvis.domain.core.Providers
{
    public class ProviderChainDomain : BaseDomain<IProviderChainRepository, ProviderChainEntity>, IProviderChainDomain
    {
        public ProviderChainDomain(IProviderChainRepository repository) : base(repository)
        {

        }
    }
}
