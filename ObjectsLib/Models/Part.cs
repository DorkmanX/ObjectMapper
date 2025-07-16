using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Part
    {
        public Part()
        {
            DeliveryAlert = new HashSet<DeliveryAlert>();
            OrderSchedule = new HashSet<OrderSchedule>();
            PartDeliveryGate = new HashSet<PartDeliveryGate>();
            PartSetPart = new HashSet<PartSetPart>();
            PullOrder = new HashSet<PullOrder>();
            StandConfig = new HashSet<StandConfig>();
            StockEntry = new HashSet<StockEntry>();
            SubstituteOriginalPart = new HashSet<Substitute>();
            SubstituteSubstitutePart = new HashSet<Substitute>();
            Transfer = new HashSet<Transfer>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? PartTypeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Source { get; set; }
        public int? WarehousePlaceId { get; set; }
        public int? SupplierId { get; set; }
        public string NamePl { get; set; }
        public int? DepotId { get; set; }
        public bool? Active { get; set; }
        public int? QtyPerPackage { get; set; }
        public int? PackagePerPlatform { get; set; }
        public int? DeliveryTypeId { get; set; }
        public int? OrderRecipientId { get; set; }
        public int? ReturnWarehousePlaceId { get; set; }
        public bool? Bc20 { get; set; }
        public string DEF { get; set; }
        public string Color { get; set; }
        public bool? FillingComponent { get; set; }
        public bool CompleteOrderByQSystem { get; set; }

        public virtual DeliveryType DeliveryType { get; set; }
        public virtual Depot Depot { get; set; }
        public virtual OrderRecipient OrderRecipient { get; set; }
        public virtual PartType PartType { get; set; }
        public virtual WarehouseVirtual ReturnWarehousePlace { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<DeliveryAlert> DeliveryAlert { get; set; }
        public virtual ICollection<OrderSchedule> OrderSchedule { get; set; }
        public virtual ICollection<PartDeliveryGate> PartDeliveryGate { get; set; }
        public virtual ICollection<PartSetPart> PartSetPart { get; set; }
        public virtual ICollection<PullOrder> PullOrder { get; set; }
        public virtual ICollection<StandConfig> StandConfig { get; set; }
        public virtual ICollection<StockEntry> StockEntry { get; set; }
        public virtual ICollection<Substitute> SubstituteOriginalPart { get; set; }
        public virtual ICollection<Substitute> SubstituteSubstitutePart { get; set; }
        public virtual ICollection<Transfer> Transfer { get; set; }
    }
}
