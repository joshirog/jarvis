using System;
using AutoMapper;
using setours.jarvis.application.dto.Providers;
using setours.jarvis.application.interfaces.Providers;
using setours.jarvis.application.validation.Providers;
using setours.jarvis.domain.entity.Providers;
using setours.jarvis.domain.interfaces.Providers;

namespace setours.jarvis.application.main.Providers
{
    public class ProviderChainApplication :
        BaseApplication<IProviderChainDomain, ProviderChainDto, ProviderChainEntity, ProviderChainValidation>, IProviderChainApplication
    {
        public ProviderChainApplication(IProviderChainDomain domain, IMapper mapper, ProviderChainValidation validation)
            : base(domain, mapper, validation)
        {

        }
    }
}
