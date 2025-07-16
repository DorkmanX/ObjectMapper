using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PartSetSet
    {
        public PartSetSet()
        {
            PartSetSetPartSet = new HashSet<PartSetSetPartSet>();
            User = new HashSet<User>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PartSetSetPartSet> PartSetSetPartSet { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
