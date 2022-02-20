using docgen_service.Database.Entities;

namespace docgen_service.Database.IncrementalData
{
    public class DocumentsTypeData
    {
        public DocumentType[] GetDocumentsTypeData()
        {
            return new DocumentType[] { 
                new DocumentType() {Id = 1, Name = "Профсуждение", Description = "Профсуждение"},
                new DocumentType() {Id = 2, Name = "Другой документ", Description = "Другой документ"}
            };
        }
    }
}
