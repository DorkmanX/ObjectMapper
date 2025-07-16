using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Supplier
    {
        public Supplier()
        {
            Part = new HashSet<Part>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Part> Part { get; set; }
    }
}
