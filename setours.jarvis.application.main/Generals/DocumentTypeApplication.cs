using AutoMapper;
using setours.jarvis.application.dto.Generals;
using setours.jarvis.application.interfaces.Generals;
using setours.jarvis.application.validation.Generals;
using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.interfaces.Generals;

namespace setours.jarvis.application.main.Generals
{
    public class DocumentTypeApplication :
        BaseApplication<IDocumentTypeDomain, DocumentTypeDto, DocumentTypeEntity, DocumentTypeValidation>, IDocumentTypeApplication
    {
        public DocumentTypeApplication(IDocumentTypeDomain domain, IMapper mapper, DocumentTypeValidation validation)
            : base(domain, mapper, validation)
        {

        }
    }
}
