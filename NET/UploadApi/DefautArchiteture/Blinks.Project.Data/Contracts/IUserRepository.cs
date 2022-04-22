using Blinks.Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Data.Contracts
{
    /// <summary>
    /// Repository user contract
    /// </summary>
    /// <seealso cref="Blinks.Project.Data.IBaseRepository&lt;Blinks.Project.Domain.User&gt;" />
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
