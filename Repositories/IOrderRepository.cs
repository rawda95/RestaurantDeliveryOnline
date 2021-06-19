using Core.DTO;

namespace Repositories.Repositories
{
    public interface IOrderRepository
    {
        int InsertOrder(OrderDTO orderDTO);
    }
}