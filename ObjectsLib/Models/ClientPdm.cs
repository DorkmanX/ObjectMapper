using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class ClientPdm
    {
        public int Id { get; set; }
        public string Line { get; set; }
        public string StandName { get; set; }
        public string Number { get; set; }
        public int Counter { get; set; }
        public DateTime Timestamp { get; set; }
        public bool? Processed { get; set; }
        public bool? OmitWhileLookingForPrevPlan { get; set; }
    }
}
