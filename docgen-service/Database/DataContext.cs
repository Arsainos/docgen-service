using Microsoft.EntityFrameworkCore;

namespace docgen_service.Database
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=codgen;Username=codgen;Password=ocwh7wfth5");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
