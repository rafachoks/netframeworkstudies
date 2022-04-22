using Blinks.Project.Data;
using Blinks.Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Service.Services
{
    [Obsolete("Não precisamos mais usar Service para comunicar com o banco, toda validação de campos deve ser feita na camada de Application")]
    public class UserService : BaseService<User>
    {
        public UserService(IBaseRepository<User> baseRepository) : base(baseRepository)
        {
        }
    }
}
