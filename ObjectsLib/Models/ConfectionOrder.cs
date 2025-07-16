using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class ConfectionOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ConfectionId { get; set; }
        public int StatusId { get; set; }
        public int? PartsetId { get; set; }
        public int? PlaceId { get; set; }
        public int? PackageQuantity { get; set; }
        public int? ArtificialOrderId { get; set; }

        public virtual PullOrder ArtificialOrder { get; set; }
        public virtual Confection Confection { get; set; }
        public virtual PullOrder Order { get; set; }
        public virtual Place Place { get; set; }
        public virtual ConfectionOrderStatus Status { get; set; }
    }
}
