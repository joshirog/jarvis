using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.interfaces.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;

namespace setours.jarvis.domain.core.Generals
{
    public class LocationDomain : BaseDomain<ILocationRepository, LocationEntity>, ILocationDomain
    {
        public LocationDomain(ILocationRepository repository) : base(repository)
        {

        }
    }
}
