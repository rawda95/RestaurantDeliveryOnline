using System.ComponentModel.DataAnnotations;

namespace Core.ViewModel
{
    public class RestaurantSearch
    {
        [Required]
        public int CityId { get; set; }
        public string RestaurantName { get; set; }
    }

}
