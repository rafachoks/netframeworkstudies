using Blinks.Project.Data;
using Blinks.Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Service.Services
{
    public class UserService : BaseService<User>
    {
        public UserService(IBaseRepository<User> baseRepository) : base(baseRepository)
        {
        }
    }
}
