using Blinks.Project.Domain;

namespace Blinks.Project.Data
{
    public interface IBaseRepository <TEntity> where TEntity : BaseEntity
    {
        void Add (TEntity entity);
        void Update (TEntity entity);
        void Delete (int id);
        TEntity Get (int id);
        IList<TEntity> GetAll ();

        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task<TEntity> GetAsync(int id);
        Task<IList<TEntity>> GetAllAsync();
    }
}
