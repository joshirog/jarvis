using FluentValidation;
using setours.jarvis.application.dto.Generals;

namespace setours.jarvis.application.validation.Generals
{
    public class LocationValidation : BaseValidation<LocationDto>
    {
        public LocationValidation()
        {
            RuleFor(d => d.Id).NotNull();
        }
    }
}
