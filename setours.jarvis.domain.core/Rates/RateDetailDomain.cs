using setours.jarvis.domain.entity.Rates;
using setours.jarvis.domain.interfaces.Rates;
using setours.jarvis.infrastructure.interfaces.Rates;

namespace setours.jarvis.domain.core.Rates
{
    public class RateDetailDomain : BaseDomain<IRateDetailRepository, RateDetailEntity>, IRateDetailDomain
    {
        public RateDetailDomain(IRateDetailRepository repository) : base(repository)
        {

        }
    }
}
