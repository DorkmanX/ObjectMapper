using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PlanClientStatus
    {
        public PlanClientStatus()
        {
            PlanPosition = new HashSet<PlanPosition>();
            PlanPositionStateOnCopying = new HashSet<PlanPositionStateOnCopying>();
        }

        public int Id { get; set; }
        public string ClientStatus { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PlanPosition> PlanPosition { get; set; }
        public virtual ICollection<PlanPositionStateOnCopying> PlanPositionStateOnCopying { get; set; }
    }
}
