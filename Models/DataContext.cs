using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Cartaz> Cartaz { get; set; }

    }
}