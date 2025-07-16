using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            PullOrder = new HashSet<PullOrder>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PullOrder> PullOrder { get; set; }
    }
}
