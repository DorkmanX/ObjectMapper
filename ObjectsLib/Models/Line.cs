using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Line
    {
        public Line()
        {
            Cycle = new HashSet<Cycle>();
            DeliveryGate = new HashSet<DeliveryGate>();
            LineSetLine = new HashSet<LineSetLine>();
            OrderSchedule = new HashSet<OrderSchedule>();
            PlanPosition = new HashSet<PlanPosition>();
            PlanPositionStateOnCopying = new HashSet<PlanPositionStateOnCopying>();
            UseGate = new HashSet<UseGate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? PlaceId { get; set; }
        public bool? Active { get; set; }
        public int? ReturnTimeSpan { get; set; }
        public int? LineType { get; set; }
        public int? ExtId { get; set; }
        public string ImportPlan { get; set; }
        public DateTime? PlanSync { get; set; }
        public bool UpdateProgress { get; set; }
        public bool BlockedForUpdatingPlan { get; set; }

        public virtual Place Place { get; set; }
        public virtual ICollection<Cycle> Cycle { get; set; }
        public virtual ICollection<DeliveryGate> DeliveryGate { get; set; }
        public virtual ICollection<LineSetLine> LineSetLine { get; set; }
        public virtual ICollection<OrderSchedule> OrderSchedule { get; set; }
        public virtual ICollection<PlanPosition> PlanPosition { get; set; }
        public virtual ICollection<PlanPositionStateOnCopying> PlanPositionStateOnCopying { get; set; }
        public virtual ICollection<UseGate> UseGate { get; set; }
    }
}
