using Blinks.Project.Domain;
using Blinks.Project.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Blinks.Project.Data
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
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

        public async Task AddAsync(TEntity entity)
        {
            await _sqlContext.Set<TEntity>().AddAsync(entity);
            await _sqlContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            _sqlContext.Set<TEntity>().Remove(Get(id));
            _sqlContext.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await GetAsync(id);

            _sqlContext.Set<TEntity>().Remove(result);

            await _sqlContext.SaveChangesAsync();
        }

        public TEntity Get(int id)
        {
            return _sqlContext.Set<TEntity>().First(x => x.Id == id);
        }

        public IList<TEntity> GetAll()
        {
            return _sqlContext.Set<TEntity>().AsNoTracking().ToList();
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _sqlContext.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _sqlContext.Set<TEntity>().FirstAsync(x => x.Id == id);
        }

        public void Update(TEntity entity)
        {
            _sqlContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sqlContext.SaveChanges();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _sqlContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _sqlContext.SaveChangesAsync();
        }
        #endregion
    }
}
