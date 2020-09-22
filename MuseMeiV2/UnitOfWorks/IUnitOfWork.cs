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
    public interface IUnitOfWork : IDisposable
    {
        //implement all get repository function here
        public CategoryRepository CategoryRepository { get; }
        public ClothRepository ClothRepository { get; }
        public OrderRepository OrderRepository { get; }
        public OrderDetailRepository OrderDetailRepository { get; }
        public RoleRepository RoleRepository { get; }
        public UserRepository UserRepository { get; }
        public Task commitAsync();
    }
}
