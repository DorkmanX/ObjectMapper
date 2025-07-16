using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PartSetType
    {
        public PartSetType()
        {
            PartSet = new HashSet<PartSet>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PartSet> PartSet { get; set; }
    }
}
