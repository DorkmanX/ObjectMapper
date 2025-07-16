using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int? RecipientId { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }

        public virtual User Recipient { get; set; }
        public virtual User Sender { get; set; }
    }
}
