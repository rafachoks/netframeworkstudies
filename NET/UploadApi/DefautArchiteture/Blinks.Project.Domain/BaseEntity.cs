using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Domain
{
    /// <summary>
    /// This base must be in every new Domain class
    /// </summary>
    public class BaseEntity
    {
        public virtual int Id { get; set; }
    }
}
