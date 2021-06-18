using Core.DTO;
using Repositories.Repositories;
using System.Collections.Generic;

namespace Services.Services
{
    public class HomeServices : IHomeServices
    {
        private readonly ICityRepository cityRepository;
        public HomeServices(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;

        }
        public List<CityDTO> GetCities()
        {
            return this.cityRepository.GetCities();
        }
    }
}
