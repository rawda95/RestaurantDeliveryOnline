using AutoMapper;
using Core.DTO;
using Microsoft.EntityFrameworkCore;
using Data.Models;
using System.Collections.Generic;

namespace Repositories.Repositories
{
    public class orderItemsRepository : BaseRepository, IorderItemsRepository
    {
        public orderItemsRepository(DbContext context, IMapper mapper) : base(context, mapper)
        {

        }


        public bool InsertList(List<OrderItemDTO> orderItemsDTO)
        {
            var orderItems = mapper.Map<List<OrderItemDTO>, List<OrderItem>>(orderItemsDTO);
            context.Set<OrderItem>().AddRange(orderItems);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }

    }
}
