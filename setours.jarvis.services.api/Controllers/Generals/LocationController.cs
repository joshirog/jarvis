using Microsoft.AspNetCore.Mvc;
using setours.jarvis.application.dto.Generals;
using setours.jarvis.application.interfaces.Generals;

namespace setours.jarvis.services.api.Controllers.Generals
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : BaseApiController<ILocationApplication, LocationDto>
    {
        public LocationController(ILocationApplication application) : base(application)
        {

        }
    }
}