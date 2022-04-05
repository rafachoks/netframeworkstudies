using Blinks.Project.Data.Context;
using Blinks.Project.Domain;

namespace Blinks.Project.Data.Repository
{
    internal class UserRepository : BaseRepository<User>
    {
        public UserRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}
