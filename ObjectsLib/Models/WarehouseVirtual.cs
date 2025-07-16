using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class WarehouseVirtual
    {
        public WarehouseVirtual()
        {
            Confection = new HashSet<Confection>();
            Part = new HashSet<Part>();
            PartSet = new HashSet<PartSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int PlaceId { get; set; }
        public string Description { get; set; }
        public int? WarehouseTypeId { get; set; }

        public virtual Place Place { get; set; }
        public virtual WarehouseType WarehouseType { get; set; }
        public virtual ICollection<Confection> Confection { get; set; }
        public virtual ICollection<Part> Part { get; set; }
        public virtual ICollection<PartSet> PartSet { get; set; }
    }
}
