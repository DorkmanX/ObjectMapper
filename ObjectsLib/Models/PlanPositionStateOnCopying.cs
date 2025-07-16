using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PlanPositionStateOnCopying
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TypeId { get; set; }
        public string Number { get; set; }
        public int? LineId { get; set; }
        public int ModelId { get; set; }
        public int QuantityRequired { get; set; }
        public int QuantityDone { get; set; }
        public int? Status { get; set; }
        public int? ClientStatus { get; set; }
        public int? QuantityRemain { get; set; }

        public virtual PlanClientStatus ClientStatusNavigation { get; set; }
        public virtual Line Line { get; set; }
        public virtual Model Model { get; set; }
        public virtual Plan Plan { get; set; }
        public virtual PlanStatus StatusNavigation { get; set; }
    }
}
