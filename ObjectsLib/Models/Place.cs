using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Place
    {
        public Place()
        {
            ConfectionOrder = new HashSet<ConfectionOrder>();
            DeliveryAlert = new HashSet<DeliveryAlert>();
            InverseParentPlace = new HashSet<Place>();
            Line = new HashSet<Line>();
            MaxStorageCapacity = new HashSet<MaxStorageCapacity>();
            OrderSchedule = new HashSet<OrderSchedule>();
            PartDeliveryGate = new HashSet<PartDeliveryGate>();
            StandConfig = new HashSet<StandConfig>();
            WarehouseVirtual = new HashSet<WarehouseVirtual>();
        }

        public int Id { get; set; }
        public int PlaceTypeId { get; set; }
        public bool Logical { get; set; }
        public int? ParentPlaceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? StockId { get; set; }
        public int? DeliveryGateId { get; set; }
        public int? UseGateId { get; set; }
        public int? SequenceNo { get; set; }
        public int? DistanceFromUseGate { get; set; }

        public virtual Place ParentPlace { get; set; }
        public virtual PlaceType PlaceType { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual UseGate UseGate { get; set; }
        public virtual ICollection<DeliveryGate> DeliveryGate { get; set; }
        public virtual ICollection<ConfectionOrder> ConfectionOrder { get; set; }
        public virtual ICollection<DeliveryAlert> DeliveryAlert { get; set; }
        public virtual ICollection<Place> InverseParentPlace { get; set; }
        public virtual ICollection<Line> Line { get; set; }
        public virtual ICollection<MaxStorageCapacity> MaxStorageCapacity { get; set; }
        public virtual ICollection<OrderSchedule> OrderSchedule { get; set; }
        public virtual ICollection<PartDeliveryGate> PartDeliveryGate { get; set; }
        public virtual ICollection<StandConfig> StandConfig { get; set; }
        public virtual ICollection<WarehouseVirtual> WarehouseVirtual { get; set; }
        public virtual ICollection<PullOrder> PullOrders { get; set; }
    }
}
