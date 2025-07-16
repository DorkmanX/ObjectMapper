using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class SubstituteType
    {
        public SubstituteType()
        {
            Substitute = new HashSet<Substitute>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Substitute> Substitute { get; set; }
    }
}
