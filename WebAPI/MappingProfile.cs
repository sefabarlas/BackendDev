using AutoMapper;
using Entities.Dtos;
using Entities.Models;

namespace WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SomeFeatureEntity, SomeFeatureEntityDto>().ReverseMap();
            CreateMap<SomeFeatureDetailEntity, SomeFeatureDetailEntityDto>().ReverseMap();
            CreateMap<SomeFeatureEntity, SomeFeatureEntityForCreationDto>().ReverseMap();
            CreateMap<SomeFeatureEntity, SomeFeatureEntityForCreationDto>().ReverseMap();
        }
    }
}