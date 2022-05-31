using Microsoft.EntityFrameworkCore;
using Portfolio_Practic.Models;

namespace Portfolio_Practic.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Portfolio> MyProperty { get; set; }
    }
}
