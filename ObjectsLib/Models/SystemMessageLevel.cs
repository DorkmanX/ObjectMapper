using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class SystemMessageLevel
    {
        public SystemMessageLevel()
        {
            SystemMessage = new HashSet<SystemMessage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public virtual ICollection<SystemMessage> SystemMessage { get; set; }
    }
}
