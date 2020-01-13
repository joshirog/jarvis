using System;
using setours.jarvis.domain.entity.Generals;
using setours.jarvis.infrastructure.interfaces.Generals;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.repository.Generals
{
    public class DocumentRepository : BaseRepository<DocumentEntity>, IDocumentRepository
    {
        public DocumentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
