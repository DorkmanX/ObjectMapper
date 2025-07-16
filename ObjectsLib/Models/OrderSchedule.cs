using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class OrderSchedule
    {
        public OrderSchedule()
        {
            PullOrder = new HashSet<PullOrder>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int PartId { get; set; }
        public int QtyTotal { get; set; }
        public int QtyRemaining { get; set; }
        public int QtyDelivered { get; set; }
        public int? LineId { get; set; }
        public int? StandId { get; set; }
        public bool? Completed { get; set; }

        public virtual Line Line { get; set; }
        public virtual Part Part { get; set; }
        public virtual Place Stand { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PullOrder> PullOrder { get; set; }
    }
}
