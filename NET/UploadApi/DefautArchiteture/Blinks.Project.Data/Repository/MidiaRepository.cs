using Blinks.Project.Data.Context;
using Blinks.Project.Domain;

namespace Blinks.Project.Data.Repository
{
    public class MidiaRepository : BaseRepository<Midia>
    {
        public MidiaRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}
