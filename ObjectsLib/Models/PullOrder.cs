using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PullOrder
    {
        public PullOrder()
        {
            ConfectionOrderArtificialOrder = new HashSet<ConfectionOrder>();
            ConfectionOrderOrder = new HashSet<ConfectionOrder>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public int PartId { get; set; }
        public int? PlaceId { get; set; }
        public int? StandConfigId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastDate { get; set; }
        public int? OrderTypeId { get; set; }
        public int SourceAmount { get; set; }
        public int? DestinationAmount { get; set; }
        public string Comment { get; set; }
        public int? PackageCount { get; set; }
        public int TimeOffset { get; set; }
        public string Gate { get; set; }
        public int? StockId { get; set; }
        public int? CurrentGateCapacity { get; set; }
        public bool? LastForPart { get; set; }
        public bool? LastFullOrder { get; set; }
        public int? MinimalQty { get; set; }
        public int? OrderRecipientId { get; set; }
        public int? TargetUserId { get; set; }
        public int? Flags { get; set; }
        public int? Reason { get; set; }
        public int? UserId { get; set; }
        public int? OrderScheduleId { get; set; }
        public int? ReturnQuantity { get; set; }
        public bool IsSubstitute { get; set; }

        public virtual OrderRecipient OrderRecipient { get; set; }
        public virtual OrderSchedule OrderSchedule { get; set; }
        public virtual OrderType OrderType { get; set; }
        public virtual Part Part { get; set; }
        public virtual Place Place { get; set; }
        public virtual StandConfig StandConfig { get; set; }
        public virtual OrderStatus Status { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual User TargetUser { get; set; }
        public virtual ICollection<ConfectionOrder> ConfectionOrderArtificialOrder { get; set; }
        public virtual ICollection<ConfectionOrder> ConfectionOrderOrder { get; set; }
    }
}
