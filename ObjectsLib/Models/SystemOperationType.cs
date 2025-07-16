using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class SystemOperationType
    {
        public SystemOperationType()
        {
            SystemOperations = new HashSet<SystemOperations>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<SystemOperations> SystemOperations { get; set; }
    }
}
