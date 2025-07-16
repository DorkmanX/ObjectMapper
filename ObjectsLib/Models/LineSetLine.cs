using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class LineSetLine
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public int LineSetId { get; set; }
        public string Name { get; set; }

        public virtual Line Line { get; set; }
        public virtual LineSet LineSet { get; set; }
    }
}
