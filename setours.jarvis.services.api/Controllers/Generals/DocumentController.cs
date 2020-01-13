using Microsoft.AspNetCore.Mvc;
using setours.jarvis.application.dto.Generals;
using setours.jarvis.application.interfaces.Generals;

namespace setours.jarvis.services.api.Controllers.Generals
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : BaseApiController<IDocumentApplication, DocumentDto>
    {
        public DocumentController(IDocumentApplication application) : base(application)
        {

        }
    }
}