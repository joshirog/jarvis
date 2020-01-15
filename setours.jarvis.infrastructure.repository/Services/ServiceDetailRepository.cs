using setours.jarvis.domain.entity.Services;
using setours.jarvis.infrastructure.interfaces.Services;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Services
{
    public class ServiceDetailRepository : BaseRepository<ServiceDetailEntity>, IServiceDetailRepository
    {
        public ServiceDetailRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
