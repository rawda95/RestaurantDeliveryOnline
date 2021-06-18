using Core.DTO;
using System.Collections.Generic;

namespace Services.Services
{
    public interface IHomeServices
    {
        List<CityDTO> GetCities();
    }
}