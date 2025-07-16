using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PartSetPart
    {
        public int Id { get; set; }
        public int? PartId { get; set; }
        public int PartSetId { get; set; }
        public int? PartTypeId { get; set; }

        public virtual Part Part { get; set; }
        public virtual PartSet PartSet { get; set; }
        public virtual PartType PartType { get; set; }
    }
}
