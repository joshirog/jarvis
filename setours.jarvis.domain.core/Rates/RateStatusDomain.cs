using setours.jarvis.domain.entity.Rates;
using setours.jarvis.domain.interfaces.Rates;
using setours.jarvis.infrastructure.interfaces.Rates;

namespace setours.jarvis.domain.core.Rates
{
    public class RateStatusDomain : BaseDomain<IRateStatusRepository, RateStatusEntity>, IRateStatusDomain
    {
        public RateStatusDomain(IRateStatusRepository repository) : base(repository)
        {

        }
    }
}
