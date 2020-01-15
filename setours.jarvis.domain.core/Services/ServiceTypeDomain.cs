using setours.jarvis.domain.entity.Services;
using setours.jarvis.domain.interfaces.Services;
using setours.jarvis.infrastructure.interfaces.Services;

namespace setours.jarvis.domain.core.Services
{
    public class ServiceTypeDomain : BaseDomain<IServiceTypeRepository, ServiceTypeEntity>, IServiceTypeDomain
    {
        public ServiceTypeDomain(IServiceTypeRepository repository) : base(repository)
        {

        }
    }
}
