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
        }
    }

}
