using Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace Web.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantServices restaurantServices;
        public RestaurantController(IRestaurantServices restaurantServices)
        {
            this.restaurantServices = restaurantServices;
        }
        public IActionResult Index()
        {
            return View();
        }
       public IActionResult SearchRestaurant(RestaurantSearch restaurantSearch)
        {
            var Model = this.restaurantServices.SearchRestaurant(restaurantSearch);
            return PartialView(Model);
        }
        public IActionResult RestaurantDetails(int id)
        {
            var Restaurant = this.restaurantServices.RestaurantDetails(id);
            return View(Restaurant);
        }

        [HttpPost]
        public IActionResult CheckOut([FromBody] CheckOutViewModel checkOutViewModel)
        {
            var result  = this.restaurantServices.CheckOut(checkOutViewModel);
            return Json(result);
        }
    }
}
