using docgen_service.Database.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace docgen_service.Database.GenericRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbContext;

        protected Repository(IUnitOfWork unitOfWork)
        {
            _dbContext = unitOfWork.Context;
        }

        public void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public TEntity FindById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> Get()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return Get().Where(predicate).AsQueryable();
        }

        public void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.Entry(entity).State = EntityState.Deleted;
        }

        public void Remove(IEnumerable<TEntity> entities)
        {
            if(entities == null || !entities.Any())
            {
                return;
            }

            foreach (var entity in entities)
            {
                _dbContext.Set<TEntity>().Add(entity);
                _dbContext.Entry(entity).State=EntityState.Deleted;
            }
        }

        public void Insert(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.Entry(entity).State = EntityState.Added;
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
            if( entities == null || !entities.Any())
            {
                return ;
            }

            foreach(var entity in entities)
            {
                _dbContext.Set<TEntity>().Add(entity);
                _dbContext.Entry(entity).State = EntityState.Added;
            }
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            if(entities==null || !entities.Any())
            {
                return;
            }

            foreach(TEntity entity in entities)
            {
                _dbContext.Set<TEntity>().Add(entity);
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
        }

        private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>().AsNoTracking();

            return includeProperties
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Include(includeProperties);
        }

        public IEnumerable<TEntity> GetWithInclude(Func<TEntity, bool> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = Include(includeProperties);

            return query.Where(predicate);
        }
    }
}
