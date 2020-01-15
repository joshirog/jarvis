using setours.jarvis.domain.entity.Rates;
using setours.jarvis.infrastructure.interfaces.Rates;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Rates
{
    public class RateStatusRepository : BaseRepository<RateStatusEntity>, IRateStatusRepository
    {
        public RateStatusRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
