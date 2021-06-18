using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class RestaurantContext : DbContext
    {

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //add dummy data
            modelBuilder.Entity<City>().HasData(
                new City() {Id=1, Name = "Mansoura" },
                new City() { Id = 2, Name = "Alexandria" },
                new City() { Id = 3, Name = "Luxor" },
                new City() { Id = 4, Name = "Asyut" },
                new City() { Id = 5, Name = "Tanta" },
                new City() { Id = 6, Name = "Luxor" },
                new City() { Id = 7, Name = "Cairo" }

                );
            modelBuilder.Entity<Restaurant>().HasData(
               new Restaurant()
               {
                   Id = 1,
                   Name = "Koshary Abou Tarek",
                   Description = "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.",
                   CityId = 6

               },
               new Restaurant()
               {
                   Id = 2,
                   Name = "Bremer",
                   Description = "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.",
                   CityId = 1,

               },
               new Restaurant()
               {
                   Id = 3,
                   Name = "Smoven restaurant",
                   Description = "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.",
                   CityId = 2,

               },
               new Restaurant()
               {
                   Id = 4,
                   Name = "Cafe Supreme",
                   Description = "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.",
                   CityId = 1,

               },
               new Restaurant()
               {
                   Id = 5,
                   Name = "Oriental Grill",
                   Description = "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.",
                   CityId = 4,

               },
               new Restaurant()
               {
                   Id = 6,
                   Name = "Shashlik",
                   Description = "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.",
                   CityId = 6,

               }
               );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Product1",Description= "Product1",Price=10,RestaurantId=1 },
                new Product() { Id = 2, Name = "Product2", Description = "Product2", Price = 14, RestaurantId = 1 },
                new Product() { Id = 3, Name = "Product3", Description = "Product3", Price = 12, RestaurantId = 1 },

                     new Product() { Id = 4, Name = "Product1", Description = "Product1", Price = 22, RestaurantId = 2 },
                new Product() { Id = 5, Name = "Product2", Description = "Product2", Price = 43, RestaurantId = 2 },
                new Product() { Id = 6, Name = "Product3", Description = "Product3", Price = 21, RestaurantId = 2 },

                            new Product() { Id = 7, Name = "Product1", Description = "Product1", Price = 54, RestaurantId = 3 },
                new Product() { Id =8, Name = "Product2", Description = "Product2", Price = 22, RestaurantId = 3},
                new Product() { Id = 9, Name = "Product3", Description = "Product3", Price = 31, RestaurantId =3}
                );
        }

    }
}
