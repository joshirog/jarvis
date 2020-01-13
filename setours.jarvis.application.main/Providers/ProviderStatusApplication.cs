using AutoMapper;
using setours.jarvis.application.dto.Providers;
using setours.jarvis.application.interfaces.Providers;
using setours.jarvis.application.validation.Providers;
using setours.jarvis.domain.entity.Providers;
using setours.jarvis.domain.interfaces.Providers;

namespace setours.jarvis.application.main.Providers
{
    public class ProviderStatusApplication :
        BaseApplication<IProviderStatusDomain, ProviderStatusDto, ProviderStatusEntity, ProviderStatusValidation>, IProviderStatusApplication
    {
        public ProviderStatusApplication(IProviderStatusDomain domain, IMapper mapper, ProviderStatusValidation validation)
            : base(domain, mapper, validation)
        {

        }
    }
}
