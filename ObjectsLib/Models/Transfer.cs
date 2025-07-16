using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Transfer
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public int? OrderId { get; set; }
        public int? SourceStockId { get; set; }
        public int? DestinationStockId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int? VehicleId { get; set; }
        public int? Quantity { get; set; }
        public int? UserId { get; set; }
        public string Number { get; set; }
        public int? FromAmount { get; set; }

        public virtual Stock DestinationStock { get; set; }
        public virtual Part Part { get; set; }
        public virtual Stock SourceStock { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual User User { get; set; }
    }
}
