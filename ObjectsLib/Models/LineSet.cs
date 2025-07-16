using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class LineSet
    {
        public LineSet()
        {
            LineSetLine = new HashSet<LineSetLine>();
            PartSet = new HashSet<PartSet>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<LineSetLine> LineSetLine { get; set; }
        public virtual ICollection<PartSet> PartSet { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
