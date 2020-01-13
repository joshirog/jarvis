using AutoMapper;
using setours.jarvis.application.dto.Providers;
using setours.jarvis.application.interfaces.Providers;
using setours.jarvis.application.validation.Providers;
using setours.jarvis.domain.entity.Providers;
using setours.jarvis.domain.interfaces.Providers;

namespace setours.jarvis.application.main.Providers
{
    public class ProviderApplication :
        BaseApplication<IProviderDomain, ProviderDto, ProviderEntity, ProviderValidation>, IProviderApplication
    {
        public ProviderApplication(IProviderDomain domain, IMapper mapper, ProviderValidation validation)
            : base(domain, mapper, validation)
        {

        }
    }
}
