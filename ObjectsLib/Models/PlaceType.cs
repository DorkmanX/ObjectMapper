using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PlaceType
    {
        public PlaceType()
        {
            Place = new HashSet<Place>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Place> Place { get; set; }
    }
}
