using AutoMapper;
using Core.DTO;
using Core.ViewModel;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class RestaurantRepository : BaseRepository, IRestaurantRepository
    {
        public RestaurantRepository(DbContext context, IMapper mapper) : base(context, mapper)
        {

        }


        public List<RestaurantDTO> SearchRestaurant(RestaurantSearch restaurantSearch)
        {
            var RestaurantList = context.Set<Restaurant>().Where(r => r.CityId == restaurantSearch.CityId &&
            (string.IsNullOrEmpty(restaurantSearch.RestaurantName) || r.Name.ToLower().Contains(restaurantSearch.RestaurantName.Trim().ToLower())))
                .ToList();
            return mapper.Map<List<Restaurant>, List<RestaurantDTO>>(RestaurantList);
        }

        public RestaurantDTO GetRestaurant(int RestaurantId)
        {
            var Restaurant = context.Set<Restaurant>().Where(r => r.Id == RestaurantId).Include(r => r.ProductList).FirstOrDefault();
            return mapper.Map<Restaurant, RestaurantDTO>(Restaurant);

        }
    }
}
