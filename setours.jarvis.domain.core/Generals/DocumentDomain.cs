using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.interfaces.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;

namespace setours.jarvis.domain.core.Generals
{
    public class DocumentDomain : BaseDomain<IDocumentRepository, DocumentEntity>, IDocumentDomain
    {
        public DocumentDomain(IDocumentRepository repository) : base(repository)
        {

        }
    }
}
