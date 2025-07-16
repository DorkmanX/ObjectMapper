using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PartType
    {
        public PartType()
        {
            MaxStorageCapacity = new HashSet<MaxStorageCapacity>();
            Part = new HashSet<Part>();
            PartSetPart = new HashSet<PartSetPart>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? PartTypeList { get; set; }
        public int? TimeSpan { get; set; }
        public int? GroupedLimit { get; set; }

        public virtual ICollection<MaxStorageCapacity> MaxStorageCapacity { get; set; }
        public virtual ICollection<Part> Part { get; set; }
        public virtual ICollection<PartSetPart> PartSetPart { get; set; }
    }
}
