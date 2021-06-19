using Core.DTO;
using Core.ViewModel;
using System.Collections.Generic;

namespace Services.Services
{
    public interface IRestaurantServices
    {
        List<RestaurantDTO> SearchRestaurant(RestaurantSearch restaurantSearch);
         RestaurantDTO RestaurantDetails(int RestaurantId);
        bool CheckOut(CheckOutViewModel checkOutViewModel);


    }
}