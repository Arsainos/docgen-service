using docgen_service.Configurations.AppSettings;
using docgen_service.Database.Configuration;
using docgen_service.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace docgen_service.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();           
        }

        public DataContext()
        {

        }
        
        public DbSet<DocumentType> DocumentsType { get; set; }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DocumentTypesConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
