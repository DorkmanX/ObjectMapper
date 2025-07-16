using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PartDeliveryGate
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public int DeleveryGateId { get; set; }
        public int? PlaceId { get; set; }
        public bool? Active { get; set; }
        //public int? ModelGroupId { get; set; }

        public virtual DeliveryGate DeleveryGate { get; set; }
        //public virtual ModelGroup ModelGroup { get; set; }
        public virtual Part Part { get; set; }
        public virtual Place Place { get; set; }
    }
}
