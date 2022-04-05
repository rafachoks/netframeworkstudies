using Blinks.Project.Domain;
using Blinks.Project.Data.Context;

namespace Blinks.Project.Data
{
    internal class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly SqlContext _sqlContext;

        public BaseRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        #region IBaseRepository Members
        public void Add(TEntity entity)
        {
            _sqlContext.Set<TEntity>().Add(entity);
            _sqlContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _sqlContext.Set<TEntity>().Remove(Get(id));
            _sqlContext.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return _sqlContext.Set<TEntity>().First(x => x.Id == id);
        }

        public IList<TEntity> GetAll()
        {
            return _sqlContext.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            _sqlContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sqlContext.SaveChanges();
        }
        #endregion
    }
}
