using Core.DTO;
using Core.ViewModel;
using System.Collections.Generic;

namespace Repositories.Repositories
{
    public interface IRestaurantRepository
    {
        RestaurantDTO GetRestaurant(int RestaurantId);
        List<RestaurantDTO> SearchRestaurant(RestaurantSearch restaurantSearch);
    }
}