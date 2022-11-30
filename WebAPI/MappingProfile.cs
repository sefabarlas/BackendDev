using AutoMapper;
using Entities.Dtos;
using Entities.Models;

namespace WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SomeFeatureEntity, SomeFeatureEntityDto>();
            CreateMap<SomeFeatureDetailEntity, SomeFeatureDetailEntityDto>();
            CreateMap<SomeFeatureEntity, SomeFeatureEntityForCreationDto>().ReverseMap();
        }
    }
}