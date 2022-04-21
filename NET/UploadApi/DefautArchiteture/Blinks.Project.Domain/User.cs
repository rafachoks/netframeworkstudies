using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime UpdateDate{ get; set; }
        public bool IsActive { get; set; }
    }
}
