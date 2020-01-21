using setours.jarvis.domain.entity.Rates;
using setours.jarvis.infrastructure.interfaces.Rates;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Rates
{
    public class RateDetailRepository : BaseRepository<RateDetailEntity>, IRateDetailRepository
    {
        public RateDetailRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
