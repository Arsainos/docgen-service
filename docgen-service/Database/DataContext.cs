using docgen_service.Configurations.AppSettings;
using docgen_service.Database.Configuration;
using docgen_service.Database.Entities;
using docgen_service.Database.IncrementalData;
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
        public DbSet<Template> Templates { get; set; }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DocumentTypesConfiguration());
            modelBuilder.ApplyConfiguration(new TemplateConfiguration());

            modelBuilder.Entity<DocumentType>().HasData(new DocumentsTypeData().GetDocumentsTypeData());
            modelBuilder.Entity<Template>().HasData(new TemplateData().GetData());

            base.OnModelCreating(modelBuilder);
        }
    }
}
