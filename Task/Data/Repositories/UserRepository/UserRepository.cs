using Task.Data.Context;
using Task.Data.Models;
using Task.Data.Repositories.GenericRepostoty;

namespace Task.Data.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly MainContext _context;

        public UserRepository(MainContext context) : base(context)
        {
            _context = context;
        }


        public List<User> GetCertificat()
        {
            return _context.Users.Where(d => d.CirtficatNum > 5).ToList();
        }



    }
}
