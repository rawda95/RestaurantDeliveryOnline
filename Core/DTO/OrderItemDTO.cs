using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class OrderItemDTO
    {
        
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public ProductDTO Product { get; set; }

        public OrderDTO Order { get; set; }
    }
}
