using setours.jarvis.domain.entity.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;
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
