using MuseMeiV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseMeiV2.Repositories.RoleRepositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        private readonly MuseMeiDbContext _context;
        public RoleRepository(MuseMeiDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
