using Core.DTO;
using System.Collections.Generic;

namespace Repositories.Repositories
{
    public interface ICityRepository
    {
        List<CityDTO> GetCities();
    }
}