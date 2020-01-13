using FluentValidation;
using setours.jarvis.application.dto.Providers;

namespace setours.jarvis.application.validation.Providers
{
    public class ProviderChainValidation : BaseValidation<ProviderChainDto>
    {
        public ProviderChainValidation()
        {
            RuleFor(d => d.Id).NotNull();
        }
    }
}
