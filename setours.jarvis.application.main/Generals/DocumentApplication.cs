using AutoMapper;
using setours.jarvis.application.dto.Generals;
using setours.jarvis.application.interfaces.Generals;
using setours.jarvis.application.validation.Generals;
using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.interfaces.Generals;

namespace setours.jarvis.application.main.Generals
{
    public class DocumentApplication :
        BaseApplication<IDocumentDomain, DocumentDto, DocumentEntity, DocumentValidation>, IDocumentApplication
    {
        public DocumentApplication(IDocumentDomain domain, IMapper mapper, DocumentValidation validation)
            : base(domain, mapper, validation)
        {

        }
    }
}
