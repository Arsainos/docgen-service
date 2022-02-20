using System.Linq.Expressions;

namespace docgen_service.Database.GenericRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        TEntity FindById(int id);
        IQueryable<TEntity> Get();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        void Remove(TEntity entity);
        void Update(TEntity entity);
    }
}
