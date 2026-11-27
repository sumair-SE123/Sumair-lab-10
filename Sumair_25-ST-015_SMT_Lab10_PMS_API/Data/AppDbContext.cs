using Microsoft.EntityFrameworkCore;
using SMT_Lab10_PMS_API.Models;

namespace SMT_Lab10_PMS_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}