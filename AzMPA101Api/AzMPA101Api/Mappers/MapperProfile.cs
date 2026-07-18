using AutoMapper;
using AzMPA101Api.Dto;
using AzMPA101Api.Dto.Order;
using AzMPA101Api.Models;

namespace AzMPA101Api.Mappers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<ProductCreateDto, Product>();
        CreateMap<CategoryCreateDto, Category>();

        CreateMap<Product, ProductDto>().ReverseMap();

        //CreateMap<OrderItemCreateDto, OrderItem>();
        //CreateMap<OrderCreateDto, Order>();

        CreateMap<Order, OrderDto>();
        CreateMap<OrderItem, OrderItemDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Product.Name))
            .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.Quantity * src.Price));
    }
}
