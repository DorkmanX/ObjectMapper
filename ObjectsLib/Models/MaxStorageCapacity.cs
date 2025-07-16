using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class MaxStorageCapacity
    {
        public int Id { get; set; }
        public int PartTypeId { get; set; }
        public int? PlaceId { get; set; }
        public int MaxCount { get; set; }
        public string Comment { get; set; }
        public bool? ContinuousDelivery { get; set; }

        public virtual PartType PartType { get; set; }
        public virtual Place Place { get; set; }
    }
}
