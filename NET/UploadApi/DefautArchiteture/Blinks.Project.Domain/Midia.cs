﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Domain
{
    /// <summary>
    /// Midia Domain for repository and service
    /// </summary>
    /// <seealso cref="Blinks.Project.Domain.BaseEntity" />
    public class Midia : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
