using MuseMeiV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseMeiV2.Repositories.UserRepositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly MuseMeiDbContext _context;

        public UserRepository(MuseMeiDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
