namespace docgen_service.Database.Entities
{
    public class Template
    {
        public int Id { get; set; }
        public int DocumentTypeId { get; set; }
        public string TemplateName { get; set; }
        public string Description { get; set; }
        public int Version { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}
