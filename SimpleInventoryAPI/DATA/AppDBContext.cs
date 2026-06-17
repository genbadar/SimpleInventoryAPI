using Microsoft.EntityFrameworkCore;
using SimpleInventoryAPI.Models;

namespace SimpleInventoryAPI.DATA
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
    }
}
