using setours.jarvis.domain.entity.Rates;
using setours.jarvis.infrastructure.interfaces.Rates;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Rates
{
    public class RateDateRepository : BaseRepository<RateDateEntity>, IRateDateRepository
    {
        public RateDateRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
