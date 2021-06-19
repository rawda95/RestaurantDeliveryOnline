using Core.DTO;
using System.Collections.Generic;

namespace Repositories.Repositories
{
    public interface IorderItemsRepository
    {
        bool InsertList(List<OrderItemDTO> orderItemsDTO);
    }
}