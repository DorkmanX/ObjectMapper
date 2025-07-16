using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Transfer = new HashSet<Transfer>();
            User = new HashSet<User>();
            VehicleLocationHistory = new HashSet<VehicleLocationHistory>();
        }

        public int Id { get; set; }
        public int? OperatorId { get; set; }
        public int VehicleTypeId { get; set; }
        public int? StockId { get; set; }
        public int? DepotId { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }
        public int? PartSetId { get; set; }
        public bool? RosaBooked { get; set; }
        public int? ParsetSetId { get; set; }

        public virtual Depot Depot { get; set; }
        public virtual User Operator { get; set; }
        public virtual PartSetSet ParsetSet { get; set; }
        public virtual PartSet PartSet { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        public virtual ICollection<Transfer> Transfer { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<VehicleLocationHistory> VehicleLocationHistory { get; set; }
    }
}
