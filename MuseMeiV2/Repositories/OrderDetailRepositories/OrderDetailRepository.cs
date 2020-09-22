using MuseMeiV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseMeiV2.Repositories.OrderDetailRepositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        private readonly MuseMeiDbContext _context;

        public OrderDetailRepository(MuseMeiDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
