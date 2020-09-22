using Microsoft.EntityFrameworkCore;
using MuseMeiV2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseMeiV2.Repositories.ClothRepositories
{
    //implement IClothRepository here as well
    public class ClothRepository : GenericRepository<Cloth>, IClothRepository
    {
        public ClothRepository(MuseMeiDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Cloth>> GetClothesByCategoryId(int id)
        {
            return await _context.Clothes.Where(c => c.CategoryId == id).ToListAsync();
        }
    }
}
