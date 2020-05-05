using AutoMapper;
using ManipulatingResources.Api.DTOS;
using ManipulatingResources.Api.Entities.Data;

namespace ManipulatingResources.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountPayable, AccountPayableDto>().ReverseMap();
        }
    }
}
