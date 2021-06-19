using Core.DTO;
using Core.ViewModel;
using System.Collections.Generic;

namespace Services.Services
{
    public interface IHomeServices
    {
        List<CityDTO> GetCities();

    }
}