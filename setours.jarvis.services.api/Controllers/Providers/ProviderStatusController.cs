using Microsoft.AspNetCore.Mvc;
using setours.jarvis.application.dto.Providers;
using setours.jarvis.application.interfaces.Providers;

namespace setours.jarvis.services.api.Controllers.Providers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderStatusController : BaseApiController<IProviderStatusApplication, ProviderStatusDto> 
    {
        public ProviderStatusController(IProviderStatusApplication application) : base(application)
        {

        }
    }
}