using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Substitute
    {
        public int Id { get; set; }
        public int SubstituteTypeId { get; set; }
        public DateTime? DateTo { get; set; }
        public string OrderNumber { get; set; }
        public int SubstitutePartId { get; set; }
        public int OriginalPartId { get; set; }
        public int? PartQuantity { get; set; }

        public virtual Part OriginalPart { get; set; }
        public virtual Part SubstitutePart { get; set; }
        public virtual SubstituteType SubstituteType { get; set; }
    }
}
