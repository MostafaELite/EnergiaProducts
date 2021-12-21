using AutoMapper;
using EnergiaProducts.Api.Controllers;
using EnergiaProducts.Domain.Models;
using EnergiaProducts.Models.Requests;

namespace EnergiaProducts.Api.Config.MappingProfiles
{
    public class ProductsMappingProfile : Profile
    {
        public ProductsMappingProfile()
        {
            CreateMap<ApiOrder, PlaceOrderRequest>();
            CreateMap<ApiOrderedProduct, OrderedItem>()
                .ForMember(dest => dest.PricePerUnit, option => option.Ignore())
                .ReverseMap();
        }
    }
}
