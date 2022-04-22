using Blinks.Project.Data.Context;
using Blinks.Project.Domain;

namespace Blinks.Project.Data.Repository
{
    /// <summary>
    /// Midia repository initialization
    /// </summary>
    /// <seealso cref="Blinks.Project.Data.BaseRepository&lt;Blinks.Project.Domain.Midia&gt;" />
    public class MidiaRepository : BaseRepository<Midia>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MidiaRepository"/> class.
        /// </summary>
        /// <param name="sqlContext">The SQL context.</param>
        public MidiaRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}
