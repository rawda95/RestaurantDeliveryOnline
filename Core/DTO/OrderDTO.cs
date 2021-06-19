using System.Collections.Generic;

namespace Core.DTO
{
    public class OrderDTO
    {
      
        public int Id { get; set; }


        public int UserId { get; set; }
        public UserDTO User { get; set; }

        public List<OrderItemDTO> orderItems { get; set; }

    }
}
