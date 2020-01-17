using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.interfaces.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;

namespace setours.jarvis.domain.core.Generals
{
    public class ServiceTypeDomain : BaseDomain<IServiceTypeRepository, ServiceTypeEntity>, IServiceTypeDomain
    {
        public ServiceTypeDomain(IServiceTypeRepository repository) : base(repository)
        {

        }
    }
}
