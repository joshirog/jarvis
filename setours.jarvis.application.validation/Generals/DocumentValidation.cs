using FluentValidation;
using setours.jarvis.application.dto.Generals;

namespace setours.jarvis.application.validation.Generals
{
    public class DocumentValidation : BaseValidation<DocumentDto>
    {
        public DocumentValidation()
        {
            RuleFor(d => d.Id).NotNull();
        }
    }
}
