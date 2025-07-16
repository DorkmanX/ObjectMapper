using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class DeliveryGate
    {
        public DeliveryGate()
        {
            PartDeliveryGate = new HashSet<PartDeliveryGate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? LineId { get; set; }
        public bool? Active { get; set; }
        public int? PlaceId { get; set; }
        public int? UseGateId { get; set; }

        public virtual Line Line { get; set; }
        public virtual Place Place { get; set; }
        public virtual UseGate UseGate { get; set; }
        public virtual ICollection<PartDeliveryGate> PartDeliveryGate { get; set; }
    }
}
