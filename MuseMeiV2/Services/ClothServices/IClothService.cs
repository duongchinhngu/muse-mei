using MuseMeiV2.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuseMeiV2.Services.ClothServices
{
    public interface IClothService : IBaseService<ClothDTO>
    {
        Task<IEnumerable<ClothDTO>> GetClothesByCategoryId(int id);
    }
}
