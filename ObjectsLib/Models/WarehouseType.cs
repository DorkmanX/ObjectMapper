using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class WarehouseType
    {
        public WarehouseType()
        {
            WarehouseVirtual = new HashSet<WarehouseVirtual>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<WarehouseVirtual> WarehouseVirtual { get; set; }
    }
}
