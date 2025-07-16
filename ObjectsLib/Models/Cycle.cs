using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Cycle
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public int Cycle1 { get; set; }

        public virtual Line Line { get; set; }
    }
}
