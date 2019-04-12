using AutoMapper;
using Hamedani.Controllers.Resources;
using Hamedani.Models;

namespace Hamedani.Controllers.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}