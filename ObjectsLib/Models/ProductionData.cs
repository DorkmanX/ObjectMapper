using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class ProductionData
    {
        public int Id { get; set; }
        public int PlanPositionId { get; set; }
        public int Counter { get; set; }
        public int UseGateId { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Processed { get; set; }
        public int? ProcessStatus { get; set; }

        public virtual PlanPosition PlanPosition { get; set; }
        public virtual UseGate UseGate { get; set; }
    }
}
