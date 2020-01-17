using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.interfaces.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;

namespace setours.jarvis.domain.core.Generals
{
    public class DocumentDomain : BaseDomain<IDocumentTypeRepository, DocumentTypeEntity>, IDocumentTypeDomain
    {
        public DocumentDomain(IDocumentTypeRepository repository) : base(repository)
        {

        }
    }
}
