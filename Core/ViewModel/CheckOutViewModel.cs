using Core.DTO;
using System.Collections.Generic;

namespace Core.ViewModel
{
    public class CheckOutViewModel
    {
        public UserDTO User { get; set; }
        public List<CartItem> Products { get; set; }

    }

}
