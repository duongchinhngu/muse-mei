using Microsoft.EntityFrameworkCore;
using MuseMeiV2.DTOs;

namespace MuseMeiV2.Models
{
    public class MuseMeiDbContext : DbContext
    {
        public MuseMeiDbContext(DbContextOptions options) : base(options)
        {
        }

        public MuseMeiDbContext()
        {

        }

        public DbSet<OrderDetail> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cloth> Clothes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MuseMeiV2.DTOs.ClothDTO> ClothDTO { get; set; }

    }
}
