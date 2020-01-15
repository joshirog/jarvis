using setours.jarvis.domain.entity.Services;
using setours.jarvis.infrastructure.interfaces.Services;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Services
{
    public class ServiceStatusRepository : BaseRepository<ServiceStatusEntity>, IServiceStatusRepository
    {
        public ServiceStatusRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
