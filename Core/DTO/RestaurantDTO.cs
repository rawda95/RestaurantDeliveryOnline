using System.Collections.Generic;

namespace Core.DTO
{
    public  class RestaurantDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CityId { get; set; }
        public CityDTO City { get; set; }

        public List<ProductDTO> ProductList { get; set; }
    }
}
