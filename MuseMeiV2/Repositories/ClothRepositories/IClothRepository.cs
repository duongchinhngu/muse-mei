
using MuseMeiV2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuseMeiV2.Repositories.ClothRepositories
{
    public interface IClothRepository : IGenericRepository<Cloth>
    {
        Task<IEnumerable<Cloth>> GetClothesByCategoryId(int id);
    }
}
