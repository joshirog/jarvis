using FluentValidation;
using setours.jarvis.application.dto;

namespace setours.jarvis.application.validation
{
    public class BaseValidation<TDataTransferObject> : AbstractValidator<TDataTransferObject>
        where TDataTransferObject : class, IDataTransferObject
    {
        public BaseValidation()
        {

        }
    }
}
