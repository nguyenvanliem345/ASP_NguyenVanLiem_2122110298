using Microsoft.EntityFrameworkCore;
using Nguyenvanliem_2122110298.Model;

namespace Nguyenvanliem_2122110298.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
