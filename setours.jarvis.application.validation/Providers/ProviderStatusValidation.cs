using FluentValidation;
using setours.jarvis.application.dto.Providers;

namespace setours.jarvis.application.validation.Providers
{
    public class ProviderStatusValidation : BaseValidation<ProviderStatusDto>
    {
        public ProviderStatusValidation()
        {
            RuleFor(d => d.Id).NotNull();
            RuleFor(d => d.Name).NotEmpty().WithMessage("Field name is required");
            RuleFor(d => d.Description).NotEmpty().WithMessage("Field description is required");
        }
    }
}
