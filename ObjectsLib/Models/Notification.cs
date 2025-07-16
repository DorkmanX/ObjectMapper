using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Notification
    {
        public int Id { get; set; }
        public int RecipientId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Extra { get; set; }
        public DateTime SendDate { get; set; }
        public int? SenderId { get; set; }
        public DateTime? ReadDate { get; set; }

        public virtual User Recipient { get; set; }
        public virtual User Sender { get; set; }
    }
}
