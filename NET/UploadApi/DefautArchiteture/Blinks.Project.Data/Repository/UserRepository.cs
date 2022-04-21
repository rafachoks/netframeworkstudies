using Blinks.Project.Data.Context;
using Blinks.Project.Data.Contracts;
using Blinks.Project.Domain;

namespace Blinks.Project.Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}
