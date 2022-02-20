using Microsoft.EntityFrameworkCore;

namespace docgen_service.Database.UnitOfWorks
{
    public class UnitOfWorkBase<T> : IUnitOfWork where T : DbContext, new()
    {
        private readonly T _dbContext;

        public DbContext Context
        {
            get 
            { 
                return _dbContext; 
            }
        }

        public UnitOfWorkBase()
        {
            _dbContext = new T();
        }

        public void Dispose()
        {
            if(_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
