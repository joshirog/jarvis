using setours.jarvis.domain.entity.Services;
using setours.jarvis.domain.interfaces.Services;
using setours.jarvis.infrastructure.interfaces.Services;

namespace setours.jarvis.domain.core.Services
{
    public class ServiceStatusDomain : BaseDomain<IServiceStatusRepository, ServiceStatusEntity>, IServiceStatusDomain
    {
        public ServiceStatusDomain(IServiceStatusRepository repository) : base(repository)
        {

        }
    }
}
