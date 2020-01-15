using setours.jarvis.domain.entity.Services;
using setours.jarvis.domain.interfaces.Services;
using setours.jarvis.infrastructure.interfaces.Services;

namespace setours.jarvis.domain.core.Services
{
    public class ServiceDetailDomain : BaseDomain<IServiceDetailRepository, ServiceDetailEntity>, IServiceDetailDomain
    {
        public ServiceDetailDomain(IServiceDetailRepository repository) : base(repository)
        {

        }
    }
}
