using docgen_service.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace docgen_service.Database.Configuration
{
    public class TemplateConfiguration : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.ToTable("Template");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.DocumentTypeId).IsRequired();
            builder.Property(t => t.TemplateName).IsRequired();
            builder.Property(t => t.Version).IsRequired();
            builder.Property(t => t.Description).IsRequired(false);
        }
    }
}
