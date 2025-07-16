using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PartSet
    {
        public PartSet()
        {
            PartSetPart = new HashSet<PartSetPart>();
            PartSetSetPartSet = new HashSet<PartSetSetPartSet>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? WarehouseVirtualId { get; set; }
        public int? DepotIdWywal { get; set; }
        public int? LineSetId { get; set; }
        public int? PartSetTypeId { get; set; }
        public bool? Bc20 { get; set; }
        public bool Technical { get; set; }
        public bool? ForVehicle { get; set; }
        public string Color { get; set; }
        public virtual Depot DepotIdWywalNavigation { get; set; }
        public virtual LineSet LineSet { get; set; }
        public virtual PartSetType PartSetType { get; set; }
        public virtual WarehouseVirtual WarehouseVirtual { get; set; }
        public virtual ICollection<PartSetPart> PartSetPart { get; set; }
        public virtual ICollection<PartSetSetPartSet> PartSetSetPartSet { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        public virtual ICollection<PartSetColor> PartSetColors { get; set; }
    }
}
