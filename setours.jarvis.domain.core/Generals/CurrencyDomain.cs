using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.interfaces.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;

namespace setours.jarvis.domain.core.Generals
{
    public class CurrencyDomain : BaseDomain<ICurrencyRepository, CurrencyEntity>, ICurrencyDomain
    {
        public CurrencyDomain(ICurrencyRepository repository) : base(repository)
        {

        }
    }
}
