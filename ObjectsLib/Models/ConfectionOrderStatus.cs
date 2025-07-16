using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class ConfectionOrderStatus
    {
        public ConfectionOrderStatus()
        {
            ConfectionOrder = new HashSet<ConfectionOrder>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ConfectionOrder> ConfectionOrder { get; set; }
    }
}
