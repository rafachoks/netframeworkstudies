using Blinks.Project.Data.Context;
using Blinks.Project.Data.Contracts;
using Blinks.Project.Domain;

namespace Blinks.Project.Data.Repository
{
    /// <summary>
    /// User repository initialization
    /// </summary>
    /// <seealso cref="Blinks.Project.Data.BaseRepository&lt;Blinks.Project.Domain.User&gt;" />
    /// <seealso cref="Blinks.Project.Data.Contracts.IUserRepository" />
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="sqlContext">The SQL context.</param>
        public UserRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}
