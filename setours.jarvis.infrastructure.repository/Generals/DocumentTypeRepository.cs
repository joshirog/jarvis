using setours.jarvis.domain.entity.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Generals
{
    public class DocumentTypeRepository : BaseRepository<DocumentTypeEntity>, IDocumentTypeRepository
    {
        public DocumentTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
