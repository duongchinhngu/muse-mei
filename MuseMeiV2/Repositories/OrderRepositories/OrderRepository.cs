using MuseMeiV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseMeiV2.Repositories.OrderRepositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly MuseMeiDbContext _context;

        public OrderRepository(MuseMeiDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
