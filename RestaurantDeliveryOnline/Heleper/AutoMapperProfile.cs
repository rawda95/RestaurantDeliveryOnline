using AutoMapper;
using Core.DTO;
using Data.Models;

namespace Web.Heleper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CityDTO, City>();
            CreateMap<City, CityDTO>();

            CreateMap<RestaurantDTO, Restaurant>();
            CreateMap<Restaurant, RestaurantDTO>();


            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();


            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();

            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();


            CreateMap<OrderItemDTO, OrderItem>();
            CreateMap<OrderItem, OrderItemDTO>();
        }
    }

}
