using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class SystemOperations
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Parameter { get; set; }
        public DateTime Time { get; set; }
        public DateTime? ProcessedTime { get; set; }
        public bool Processed { get; set; }
        public int? UserId { get; set; }

        public virtual SystemOperationType Type { get; set; }
        public virtual User User { get; set; }
    }
}
