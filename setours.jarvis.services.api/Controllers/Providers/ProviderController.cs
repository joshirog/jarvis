using Microsoft.AspNetCore.Mvc;
using setours.jarvis.application.dto.Providers;
using setours.jarvis.application.interfaces.Providers;
using setours.jarvis.transversal.common.Bases.Querys;
using System.Threading.Tasks;

namespace setours.jarvis.services.api.Controllers.Providers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : BaseApiController<IProviderApplication, ProviderDto>
    {
        public ProviderController(IProviderApplication application) : base(application)
        {

        }

        [HttpPost("Search2")]
        public async Task<IActionResult> GetSearch2([FromBody] BaseSearchQuery search)
        {
            return Ok(await _application.GetSearch2(search));
        }
    }
}