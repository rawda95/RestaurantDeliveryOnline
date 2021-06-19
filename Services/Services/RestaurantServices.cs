using Core.DTO;
using Core.ViewModel;
using Repositories.Repositories;
using System.Collections.Generic;

namespace Services.Services
{

    public class RestaurantServices : IRestaurantServices
    {
        private readonly IRestaurantRepository restaurantRepository;

        private readonly IUserRepository userRepository;
        private readonly IOrderRepository orderRepository;

        private readonly IorderItemsRepository iorderItemsRepository ;


        public RestaurantServices(IRestaurantRepository restaurantRepository,
           IOrderRepository orderRepository,
           IorderItemsRepository iorderItemsRepository,
           IUserRepository userRepository
           )
        {
            this.restaurantRepository = restaurantRepository;
            this.orderRepository = orderRepository;
            this.iorderItemsRepository = iorderItemsRepository;
            this.userRepository = userRepository;


        }
        public List<RestaurantDTO> SearchRestaurant(RestaurantSearch restaurantSearch)
        {
            return this.restaurantRepository.SearchRestaurant(restaurantSearch);
        }
        public RestaurantDTO RestaurantDetails(int RestaurantId)
        {
            return this.restaurantRepository.GetRestaurant(RestaurantId);
        }

        public bool CheckOut(CheckOutViewModel checkOutViewModel)
        {
               var UserId = this.userRepository.InsertUser(checkOutViewModel?.User);
                var OederId = this.orderRepository.InsertOrder(new OrderDTO() { UserId = UserId });

                List<OrderItemDTO> orderItems = new List<OrderItemDTO>();
                foreach (var item in checkOutViewModel.Products)
                {
                    orderItems.Add(new OrderItemDTO()
                    {
                        OrderId = OederId,
                        ProductId = item.Id,
                        Quantity = item.Quantity
                    });
                }
                var result = this.iorderItemsRepository.InsertList(orderItems);
                return result;
            
        }
    }
}
