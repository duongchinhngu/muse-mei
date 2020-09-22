using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuseMeiV2.Repositories
{
    //interface for basic CRUD from DB
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        void Update(T entity);
        void Insert(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
