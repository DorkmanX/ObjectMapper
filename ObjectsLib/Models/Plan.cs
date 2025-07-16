using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Plan
    {
        public Plan()
        {
            PlanPosition = new HashSet<PlanPosition>();
            PlanPositionStateOnCopying = new HashSet<PlanPositionStateOnCopying>();
        }

        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public int? Rfu { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<PlanPosition> PlanPosition { get; set; }
        public virtual ICollection<PlanPositionStateOnCopying> PlanPositionStateOnCopying { get; set; }
    }
}
