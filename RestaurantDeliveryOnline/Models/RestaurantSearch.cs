using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class RestaurantSearch
    {
        [Required]
        public int CityId { get; set; }
        public string RestaurantName { get; set; }
    }
}
