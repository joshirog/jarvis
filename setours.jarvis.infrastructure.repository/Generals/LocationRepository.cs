using setours.jarvis.domain.entity.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Generals
{
    public class LocationRepository : BaseRepository<LocationEntity>, ILocationRepository
    {
        public LocationRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
