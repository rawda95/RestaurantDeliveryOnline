using Core.DTO;

namespace Repositories.Repositories
{
    public interface IUserRepository
    {
        int InsertUser(UserDTO user);
    }
}