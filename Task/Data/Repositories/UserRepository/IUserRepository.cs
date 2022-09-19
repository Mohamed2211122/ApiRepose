using Task.Data.Models;
using Task.Data.Repositories.GenericRepostoty;

namespace Task.Data.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        List<User> GetUser();
    }
}
