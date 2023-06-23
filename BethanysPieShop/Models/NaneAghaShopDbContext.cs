using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace naneAgha.Models
{
    public class NaneAghaShopDbContext : DbContext
    {

        public NaneAghaShopDbContext(DbContextOptions<NaneAghaShopDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}

       
    }
}
