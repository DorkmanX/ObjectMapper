using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PreassemblyHistory
    {
        public int Id { get; set; }
        public int PlanPositionId { get; set; }
        public int UserId { get; set; }
        public int PartId { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool? Done { get; set; }
        public int Quantity { get; set; }
        public DateTime? ConfirmTimeStamp { get; set; }
        

        public virtual PlanPosition PlanPosition { get; set; }
        public virtual Part Part { get; set; }
        public virtual User User { get; set; }
    }
}
