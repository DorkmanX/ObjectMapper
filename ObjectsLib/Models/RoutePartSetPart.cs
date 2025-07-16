namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class RoutePartSetPart
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int PartSetPartId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual PartSetPart PartSetPart { get; set; }
        public virtual Route Route { get; set; }
    }
}
