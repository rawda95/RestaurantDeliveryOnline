using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<Product> ProductList { get; set; }
    }
}
