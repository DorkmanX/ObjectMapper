using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class VehicleLocationHistory
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public int? OperatorId { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual User Operator { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
