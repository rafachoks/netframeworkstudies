using Blinks.Project.Data.Context;
using Blinks.Project.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Data.Repository
{
    internal class UserRepository : BaseRepository<User>
    {
        public UserRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}
