using MuseMeiV2.Models;
using MuseMeiV2.Repositories.CategoryRepositories;
using MuseMeiV2.Repositories.ClothRepositories;
using MuseMeiV2.Repositories.OrderDetailRepositories;
using MuseMeiV2.Repositories.OrderRepositories;
using MuseMeiV2.Repositories.RoleRepositories;
using MuseMeiV2.Repositories.UserRepositories;
using System;
using System.Threading.Tasks;

namespace MuseMeiV2.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue;
        private MuseMeiDbContext _context;

        public UnitOfWork(MuseMeiDbContext context)
        {
            _context = context;
            InitRepositories();
        }

        private void InitRepositories()
        {
            CategoryRepository = new CategoryRepository(_context);
            ClothRepository = new ClothRepository(_context);
            OrderRepository = new OrderRepository(_context);
            OrderDetailRepository = new OrderDetailRepository(_context);
            RoleRepository = new RoleRepository(_context);
            UserRepository = new UserRepository(_context);
        }

        public CategoryRepository CategoryRepository { get; private set; }

        public ClothRepository ClothRepository { get; private set; }

        public OrderRepository OrderRepository { get; private set; }

        public OrderDetailRepository OrderDetailRepository { get; private set; }


        public RoleRepository RoleRepository { get; private set; }

        public UserRepository UserRepository { get; private set; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        public async Task commitAsync()
        {
            await _context.SaveChangesAsync();
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
