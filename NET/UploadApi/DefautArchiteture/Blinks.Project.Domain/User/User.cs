using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Domain.User
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime CreateTime{ get; set; }
        public DateTime UpdateTime{ get; set; }
        public bool IsActive { get; set; }
    }
}
