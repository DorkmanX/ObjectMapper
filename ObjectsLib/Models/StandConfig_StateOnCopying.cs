using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class StandConfigStateOnCopying
    {
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public int PartId { get; set; }
        public int ModelId { get; set; }
        public string Number { get; set; }
    }
}
