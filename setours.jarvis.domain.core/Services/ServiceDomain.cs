using setours.jarvis.domain.entity.Services;
using setours.jarvis.domain.interfaces.Services;
using setours.jarvis.infrastructure.interfaces.Services;

namespace setours.jarvis.domain.core.Services
{
    public class ServiceDomain : BaseDomain<IServiceRepository, ServiceEntity>, IServiceDomain
    {
        public ServiceDomain(IServiceRepository repository) : base(repository)
        {

        }
    }
}
