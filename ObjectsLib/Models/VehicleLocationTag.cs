using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class VehicleLocationTag
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
    }
}
