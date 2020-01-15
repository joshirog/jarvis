using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.interfaces.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;

namespace setours.jarvis.domain.core.Generals
{
    public class OccupationDomain : BaseDomain<IOccupationRepository, OccupationEntity>, IOccupationDomain
    {
        public OccupationDomain(IOccupationRepository repository) : base(repository)
        {

        }
    }
}
