using Microsoft.EntityFrameworkCore;

namespace docgen_service.Database.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        DbContext Context { get; }
    }
}
