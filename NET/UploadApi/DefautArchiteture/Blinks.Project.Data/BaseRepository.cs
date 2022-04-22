using Blinks.Project.Domain;
using Blinks.Project.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Blinks.Project.Data
{
    /// <summary>
    /// Database standard configuration - do not change this
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="Blinks.Project.Data.IBaseRepository&lt;TEntity&gt;" />
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly SqlContext _sqlContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="sqlContext">The SQL context.</param>
        public BaseRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        #region IBaseRepository Members
        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Add(TEntity entity)
        {
            _sqlContext.Set<TEntity>().Add(entity);
            _sqlContext.SaveChanges();
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public async Task AddAsync(TEntity entity)
        {
            await _sqlContext.Set<TEntity>().AddAsync(entity);
            await _sqlContext.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            _sqlContext.Set<TEntity>().Remove(Get(id));
            _sqlContext.SaveChanges();
        }

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteAsync(int id)
        {
            var result = await GetAsync(id);

            _sqlContext.Set<TEntity>().Remove(result);

            await _sqlContext.SaveChangesAsync();
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public TEntity Get(int id)
        {
            return _sqlContext.Set<TEntity>().First(x => x.Id == id);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IList<TEntity> GetAll()
        {
            return _sqlContext.Set<TEntity>().AsNoTracking().ToList();
        }

        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _sqlContext.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<TEntity> GetAsync(int id)
        {
            return await _sqlContext.Set<TEntity>().FirstAsync(x => x.Id == id);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(TEntity entity)
        {
            _sqlContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sqlContext.SaveChanges();
        }

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public async Task UpdateAsync(TEntity entity)
        {
            _sqlContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _sqlContext.SaveChangesAsync();
        }
        #endregion
    }
}
