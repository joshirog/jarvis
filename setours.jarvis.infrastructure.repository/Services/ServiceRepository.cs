using setours.jarvis.domain.entity.Services;
using setours.jarvis.infrastructure.interfaces.Services;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Services
{
    public class ServiceRepository : BaseRepository<ServiceEntity>, IServiceRepository
    {
        public ServiceRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
