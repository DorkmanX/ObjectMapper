using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class StockEntry
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public int? Quantity { get; set; }
        public int StockId { get; set; }
        public int ReturnReserved { get; set; }
        public DateTime? LastTransferIn { get; set; }

        public virtual Part Part { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
