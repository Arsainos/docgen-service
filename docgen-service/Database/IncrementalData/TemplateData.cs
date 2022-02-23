using docgen_service.Database.Entities;

namespace docgen_service.Database.IncrementalData
{
    public class TemplateData
    {
        public Template[] GetData()
        {
            return new Template[] {
                new Template() { Id = 1, TemplateName = "Профсуждение", Description = "Формирование о хозяйственной деятельности профсуждений", DocumentTypeId = 1, Version = 1}
            };
        }
    }
}
