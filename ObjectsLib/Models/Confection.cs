using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Confection
    {
        public Confection()
        {
            ConfectionOrder = new HashSet<ConfectionOrder>();
        }

        public int Id { get; set; }
        public int StatusId { get; set; }
        public int PlanPositionId { get; set; }
        public int WarehouseId { get; set; }
        public string Number { get; set; }
        public int? OperatorId { get; set; }

        public virtual User Operator { get; set; }
        public virtual PlanPosition PlanPosition { get; set; }
        public virtual ConfectionStatus Status { get; set; }
        public virtual WarehouseVirtual Warehouse { get; set; }
        public virtual ICollection<ConfectionOrder> ConfectionOrder { get; set; }
    }
}
