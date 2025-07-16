using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class OrderRecipient
    {
        public OrderRecipient()
        {
            Part = new HashSet<Part>();
            PullOrder = new HashSet<PullOrder>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Part> Part { get; set; }
        public virtual ICollection<PullOrder> PullOrder { get; set; }
    }
}
