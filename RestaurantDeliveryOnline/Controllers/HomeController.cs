using Microsoft.AspNetCore.Mvc;
using RestaurantDeliveryOnline.Models;
using Services.Services;
using System.Diagnostics;

namespace RestaurantDeliveryOnline.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHomeServices homeServices ;

        public HomeController(IHomeServices homeServices)
        {
            this.homeServices = homeServices;
        }

        public IActionResult Index()
        {
            ViewBag.Cities = this.homeServices.GetCities();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
