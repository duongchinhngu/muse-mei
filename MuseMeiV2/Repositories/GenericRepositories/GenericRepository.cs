using Microsoft.EntityFrameworkCore;
using MuseMeiV2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuseMeiV2.Repositories
{
    //contain all basic function CRUD from DB: getById, getAll(), Delete(by id and by Object), Update, Create
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly MuseMeiDbContext _context;
        protected readonly DbSet<T> _dbSet;

        protected GenericRepository(MuseMeiDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async void Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            Delete(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async void Insert(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
