using setours.jarvis.domain.entity.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Generals
{
    public class OccupationRepository : BaseRepository<OccupationEntity>, IOccupationRepository
    {
        public OccupationRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
