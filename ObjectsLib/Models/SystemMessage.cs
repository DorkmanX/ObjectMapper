using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class SystemMessage
    {
        public int Id { get; set; }
        public string Parameter { get; set; }
        public string Description { get; set; }
        public int MessageTypeId { get; set; }
        public int MessageLevelId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedById { get; set; }
        public bool? Seen { get; set; }
        public int? SeenById { get; set; }
        public DateTime? SeenDate { get; set; }
        public bool? Processed { get; set; }
        public int? ProcessedById { get; set; }
        public DateTime? ProcessedDate { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual SystemMessageLevel MessageLevel { get; set; }
        public virtual SystemMessageType MessageType { get; set; }
        public virtual User ProcessedBy { get; set; }
        public virtual User SeenBy { get; set; }
    }
}
