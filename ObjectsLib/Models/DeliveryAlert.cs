using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class DeliveryAlert
    {
        public int Id { get; set; }
        public int? PlaceId { get; set; }
        public int? PartId { get; set; }
        public int Deadline { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Confirmed { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public int? AddedByUserId { get; set; }
        public int? ConfirmedByUserId { get; set; }
        public int? RecipientId { get; set; }

        public virtual User AddedByUser { get; set; }
        public virtual User ConfirmedByUser { get; set; }
        public virtual Part Part { get; set; }
        public virtual Place Place { get; set; }
        public virtual User Recipient { get; set; }
    }
}
