using setours.jarvis.domain.entity.Services;
using setours.jarvis.infrastructure.interfaces.Services;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Services
{
    public class ServiceTypeRepository : BaseRepository<ServiceTypeEntity>, IServiceTypeRepository
    {
        public ServiceTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
