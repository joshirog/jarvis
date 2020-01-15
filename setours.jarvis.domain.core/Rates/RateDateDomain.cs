using setours.jarvis.domain.entity.Rates;
using setours.jarvis.domain.interfaces.Rates;
using setours.jarvis.infrastructure.interfaces.Rates;

namespace setours.jarvis.domain.core.Rates
{
    public class RateDateDomain : BaseDomain<IRateDateRepository, RateDateEntity>, IRateDateDomain
    {
        public RateDateDomain(IRateDateRepository repository) : base(repository)
        {

        }
    }
}
