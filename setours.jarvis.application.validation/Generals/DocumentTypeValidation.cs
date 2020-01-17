using FluentValidation;
using setours.jarvis.application.dto.Generals;

namespace setours.jarvis.application.validation.Generals
{
    public class DocumentTypeValidation : BaseValidation<DocumentTypeDto>
    {
        public DocumentTypeValidation()
        {
            RuleFor(d => d.Id).NotNull();
        }
    }
}
