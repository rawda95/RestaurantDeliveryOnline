namespace Core.DTO
{
    public  class ProductDTO
    {

        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }

        public int RestaurantId { get; set; }
        public RestaurantDTO Restaurant { get; set; }

    }
}
