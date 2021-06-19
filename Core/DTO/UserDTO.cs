using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public int Phone { get; set; }
        [Required]

        public string Address { get; set; }

        [Required]
        public string Email { get; set; }
        public List<OrderDTO> Orders { get; set; }

    }
}
