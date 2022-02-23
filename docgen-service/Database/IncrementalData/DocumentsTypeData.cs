using docgen_service.Database.Entities;
using docgen_service.Database.Interfaces;

namespace docgen_service.Database.IncrementalData
{
    public class DocumentsTypeData : IIncrementalData<DocumentType>
    {
        public DocumentType[] GetData()
        {
            return new DocumentType[] {
                new DocumentType() {Id = 1, Name = "Профсуждение", Description = "Профсуждение"},
                new DocumentType() {Id = 2, Name = "Другой документ", Description = "Другой документ"}
            };
        }
    }
}
