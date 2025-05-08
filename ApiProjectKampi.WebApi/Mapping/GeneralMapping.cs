using ApiProjectKampi.WebApi.Entities;
using AutoMapper;
using ApiProjectKampi.WebApi.Dtos.FeatureDtos;
using ApiProjectKampi.WebApi.Dtos.MessageDtos;
using ApiProjectKampi.WebApi.Entities;
using ApiProjectKampi.WebApi.Dtos.ProductDtos;


namespace ApiProjectKampi.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIDFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIDMessageDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWCategoryDto>().ForMember(x=>x.CategoryName,y=>y.MapFrom(z=>z.category.CategoryName)).ReverseMap();
        }
    }
} 
