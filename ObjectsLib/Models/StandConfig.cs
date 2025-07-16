using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class StandConfig
    {
        public StandConfig()
        {
            PullOrder = new HashSet<PullOrder>();
        }

        public int Id { get; set; }
        public int? PlaceId { get; set; }
        public int PartId { get; set; }
        public double? CountPerCycle { get; set; }
        public string Description { get; set; }
        public int? WorkOrderFileId { get; set; }
        public int ModelId { get; set; }
        public string Number { get; set; }
        public bool? DecrementStock { get; set; }
        public bool? UseStandStockQty { get; set; }
        public int? LineId { get; set; }

        public virtual Model Model { get; set; }
        public virtual Part Part { get; set; }
        public virtual Place Place { get; set; }
        public virtual WorkOrderHistory WorkOrderHistory { get; set; }
        public virtual ICollection<PullOrder> PullOrder { get; set; }
    }
}
