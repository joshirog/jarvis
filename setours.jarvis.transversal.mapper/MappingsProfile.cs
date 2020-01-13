using AutoMapper;
using setours.jarvis.application.dto.Generals;
using setours.jarvis.application.dto.Providers;
using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.entity.Providers;

namespace setours.jarvis.transversal.mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<DocumentEntity, DocumentDto>().ReverseMap();
            CreateMap<LocationEntity, LocationDto>().ReverseMap();
            CreateMap<ProviderStatusEntity, ProviderStatusDto>().ReverseMap();
            CreateMap<ProviderChainEntity, ProviderChainDto>().ReverseMap();
            CreateMap<ProviderEntity, ProviderDto>().ReverseMap();
        }
    }
}
