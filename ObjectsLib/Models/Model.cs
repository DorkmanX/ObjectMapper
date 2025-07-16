using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Model
    {
        public Model()
        {
            PlanPosition = new HashSet<PlanPosition>();
            PlanPositionStateOnCopying = new HashSet<PlanPositionStateOnCopying>();
            StandConfig = new HashSet<StandConfig>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public string Group { get; set; }

        public virtual ICollection<PlanPosition> PlanPosition { get; set; }
        public virtual ICollection<PlanPositionStateOnCopying> PlanPositionStateOnCopying { get; set; }
        public virtual ICollection<StandConfig> StandConfig { get; set; }
    }
}
