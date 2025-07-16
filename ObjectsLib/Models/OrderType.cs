using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class OrderType
    {
        public OrderType()
        {
            PullOrder = new HashSet<PullOrder>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PullOrder> PullOrder { get; set; }
    }
}
