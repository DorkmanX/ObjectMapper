using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class UseGate
    {
        public UseGate()
        {
            Place = new HashSet<Place>();
            ProductionData = new HashSet<ProductionData>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? LineId { get; set; }
        public bool? Active { get; set; }
        public bool? LastWitinLine { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public bool? FirstWithinLine { get; set; }
        public string LastOrderNumber { get; set; }
        public int? OffsetFromPhisicalGate { get; set; }
        public bool? Virtual { get; set; }

        public virtual Line Line { get; set; }
        public virtual ICollection<Place> Place { get; set; }
        public virtual ICollection<ProductionData> ProductionData { get; set; }
        public virtual ICollection<DeliveryGate> DeliveryGate { get; set; }
    }
}
