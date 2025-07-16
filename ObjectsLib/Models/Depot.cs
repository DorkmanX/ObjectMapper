using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Depot
    {
        public Depot()
        {
            Part = new HashSet<Part>();
            PartSet = new HashSet<PartSet>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? StockId { get; set; }

        public virtual Stock Stock { get; set; }
        public virtual ICollection<Part> Part { get; set; }
        public virtual ICollection<PartSet> PartSet { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
