using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class WorkOrderHistory
    {
        public WorkOrderHistory()
        {
            StandConfig = new HashSet<StandConfig>();
        }

        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual ICollection<StandConfig> StandConfig { get; set; }
    }
}
