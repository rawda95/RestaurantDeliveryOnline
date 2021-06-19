using AutoMapper;
using Core.DTO;
using Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Repositories.Repositories
{
    public class UserRepository : BaseRepository,IUserRepository
    {
        public UserRepository(DbContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public int InsertUser(UserDTO userDTO)
        {
            var User = mapper.Map<UserDTO, User>(userDTO);
            context.Set<User>().Add(User);
            try
            {
                context.SaveChanges();
                return User.Id;
            }
            catch
            {
                return 0;
            }


        }

    }
}
