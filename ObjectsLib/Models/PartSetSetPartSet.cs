using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PartSetSetPartSet
    {
        public int Id { get; set; }
        public int PartSetId { get; set; }
        public int PartSetSetId { get; set; }

        public virtual PartSet PartSet { get; set; }
        public virtual PartSetSet PartSetSet { get; set; }
    }
}
