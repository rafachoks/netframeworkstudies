using Blinks.Project.Data.Context;
using Blinks.Project.Domain;

namespace Blinks.Project.Data.Repository
{
    internal class MidiaRepository : BaseRepository<Midia>
    {
        public MidiaRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}
