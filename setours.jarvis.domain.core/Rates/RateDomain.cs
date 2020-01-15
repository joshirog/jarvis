using setours.jarvis.domain.entity.Rates;
using setours.jarvis.domain.interfaces.Rates;
using setours.jarvis.infrastructure.interfaces.Rates;

namespace setours.jarvis.domain.core.Rates
{
    public class RateDomain : BaseDomain<IRateRepository, RateEntity>, IRateDomain
    {
        public RateDomain(IRateRepository repository) : base(repository)
        {

        }
    }
}
