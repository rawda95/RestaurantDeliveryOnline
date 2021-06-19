using AutoMapper;
using Core.DTO;
using Microsoft.EntityFrameworkCore;
using Data.Models;

namespace Repositories.Repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {

        public OrderRepository(DbContext context, IMapper mapper) : base(context, mapper)
        {

        }


        public int InsertOrder(OrderDTO orderDTO)
        {
            var Order = mapper.Map<OrderDTO, Order>(orderDTO);
            context.Set<Order>().Add(Order);
            try
            {
                context.SaveChanges();
                return Order.Id;
            }
            catch
            {
                return 0;
            }


        }


    }
}
