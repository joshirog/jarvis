using AutoMapper;
using setours.jarvis.application.dto.Generals;
using setours.jarvis.application.interfaces.Generals;
using setours.jarvis.application.validation.Generals;
using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.interfaces.Generals;

namespace setours.jarvis.application.main.Generals
{
    public class LocationApplication :
        BaseApplication<ILocationDomain, LocationDto, LocationEntity, LocationValidation>, ILocationApplication
    {
        public LocationApplication(ILocationDomain domain, IMapper mapper, LocationValidation validation)
            : base(domain, mapper, validation)
        {

        }
    }
}
