using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class ConfectionStatus
    {
        public ConfectionStatus()
        {
            Confection = new HashSet<Confection>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Confection> Confection { get; set; }
    }
}
