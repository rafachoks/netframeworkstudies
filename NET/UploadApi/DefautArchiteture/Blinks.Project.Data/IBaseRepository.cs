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
    }
}
