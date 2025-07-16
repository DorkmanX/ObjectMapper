using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class SystemMessageType
    {
        public SystemMessageType()
        {
            SystemMessage = new HashSet<SystemMessage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SystemMessage> SystemMessage { get; set; }
    }
}
