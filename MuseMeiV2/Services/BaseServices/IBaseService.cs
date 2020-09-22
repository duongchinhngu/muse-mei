using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuseMeiV2.Services
{
    public interface IBaseService<Dto>
        where Dto : class
    {
        Task Add(Dto dto);
        Task Delete(int id);
        Task Update(Dto dto);
        Task<Dto> Get(int id);
        Task<IEnumerable<Dto>> GetAll();
    }
}
