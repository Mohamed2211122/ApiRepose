using Task.Data.Context;
using Task.Data.Models;
using Task.Data.Repositories.GenericRepostoty;

namespace Task.Data.Repositories.CertifcationRepository
{
    public class CertifcationRepository : GenericRepository<Certification>, ICertifcationRepository
    {
        private readonly MainContext _context;

        public CertifcationRepository(MainContext context) : base(context)
        {
            _context = context;
        }




    }
}
