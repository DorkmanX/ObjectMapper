using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Route
    {
        public Route()
        {
            RoutePartSetPart = new HashSet<RoutePartSetPart>();
        }

        public int Id { get; set; }
        public int SourcePlaceId { get; set; }
        public int LineSetLineId { get; set; }
        public int? IntermediatePlaceId { get; set; }

        public virtual Place IntermediatePlace { get; set; }
        public virtual LineSetLine LineSetLine { get; set; }
        public virtual Place SourcePlace { get; set; }
        public virtual ICollection<RoutePartSetPart> RoutePartSetPart { get; set; }
    }
}
