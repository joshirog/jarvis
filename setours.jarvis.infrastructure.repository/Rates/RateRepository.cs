using setours.jarvis.domain.entity.Rates;
using setours.jarvis.infrastructure.interfaces.Rates;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Rates
{
    public class RateRepository : BaseRepository<RateEntity>, IRateRepository
    {
        public RateRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
