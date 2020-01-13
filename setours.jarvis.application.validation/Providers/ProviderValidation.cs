using FluentValidation;
using setours.jarvis.application.dto.Providers;

namespace setours.jarvis.application.validation.Providers
{
    public class ProviderValidation : BaseValidation<ProviderDto>
    {
        public ProviderValidation()
        {
            RuleFor(d => d.Id).NotNull();
        }
    }
}
